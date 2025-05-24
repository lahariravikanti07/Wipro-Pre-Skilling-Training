using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Create tasks with different delays
        var task1 = TaskWithDelay("Task 1", 3000);
        var task2 = TaskWithDelay("Task 2", 1000);
        var task3 = TaskWithDelay("Task 3", 2000);

        // Wait for any task to complete
        Task<string> firstFinished = await Task.WhenAny(task1, task2, task3);

        // Print the name of the first task to finish
        Console.WriteLine($"First completed: {firstFinished.Result}");
    }

    static async Task<string> TaskWithDelay(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }
}
