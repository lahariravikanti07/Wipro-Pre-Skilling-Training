using System;
using System.Threading;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all tasks...");

        // Start tasks simultaneously (they begin running now)
        Task task1 = DoWorkAsync("Task 1", 2000);
        Task task2 = DoWorkAsync("Task 2", 3000);
        Task task3 = DoWorkAsync("Task 3", 1000);

        // Await all tasks to complete
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("All tasks completed.");
    }

    static async Task DoWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);    // Simulates async work
        Console.WriteLine($"{name} completed after {delay}ms.");
    }
}