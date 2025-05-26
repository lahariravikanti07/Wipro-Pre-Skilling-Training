using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting tasks...\n");

        var tasks = new List<Task>
        {
            Task.Run(() => DoWork(1)),
            Task.Run(() => DoWorkWithException(2)),
            Task.Run(() => DoWork(3)),
            Task.Run(() => DoWorkWithException(4)),
            Task.Run(() => DoWork(5))
        };

        try
        {
            // Wait for all tasks to complete
            await Task.WhenAll(tasks);
        }
        catch (AggregateException ex)
        {
            Console.WriteLine("Caught AggregateException!\n");

            foreach (var inner in ex.InnerExceptions)
            {
                Console.WriteLine($"Error: {inner.Message}");
            }
        }
        catch (Exception ex)
        {
            // Handle any non-aggregated exceptions (unlikely in this context)
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        Console.WriteLine("\nAll tasks attempted. Program finished.");
    }

    static void DoWork(int taskId)
    {
        Console.WriteLine($"Task {taskId} started.");
        Task.Delay(1000).Wait();  // Simulate work
        Console.WriteLine($"Task {taskId} completed successfully.");
    }

    static void DoWorkWithException(int taskId)
    {
        Console.WriteLine($"Task {taskId} started.");
        Task.Delay(1000).Wait();  // Simulate work
        throw new InvalidOperationException($"Task {taskId} encountered an error.");
    }
}
