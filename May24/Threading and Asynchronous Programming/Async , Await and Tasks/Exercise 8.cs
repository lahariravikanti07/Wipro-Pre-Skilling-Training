using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var taskNames = new[] { "Task1", "Task2", "Task3", "Task4" };
        var tasks = taskNames.Select(name => RiskyTaskAsync(name)).ToList();

        try
        {
            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks completed successfully.");
        }
        catch
        {
            Console.WriteLine("One or more tasks failed.");

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].IsFaulted)
                {
                    Console.WriteLine($"{taskNames[i]} failed: {tasks[i].Exception?.GetBaseException().Message}");
                }
            }
        }
    }

    static async Task RiskyTaskAsync(string name)
    {
        await Task.Delay(1000); // Simulate async work

        if (name == "Task3")
        {
            throw new InvalidOperationException($"{name} encountered an error.");
        }

        Console.WriteLine($"{name} completed successfully.");
    }
}
