using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Sequential Execution
        Stopwatch sw = Stopwatch.StartNew();
        await SimulateWorkAsync("Task 1", 2000);
        await SimulateWorkAsync("Task 2", 2000);
        await SimulateWorkAsync("Task 3", 2000);
        sw.Stop();
        Console.WriteLine($"Sequential execution took: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine(new string('-', 40));

        // Parallel Execution
        sw.Restart();
        Task t1 = SimulateWorkAsync("Task 1", 2000);
        Task t2 = SimulateWorkAsync("Task 2", 2000);
        Task t3 = SimulateWorkAsync("Task 3", 2000);
        await Task.WhenAll(t1, t2, t3);
        sw.Stop();
        Console.WriteLine($"Parallel execution took: {sw.ElapsedMilliseconds} ms");
    }

    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay); // Simulates async work
        Console.WriteLine($"{name} completed after {delay} ms.");
    }
}
