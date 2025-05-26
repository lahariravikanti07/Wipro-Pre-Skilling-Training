using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var cts = new CancellationTokenSource();

        // Start all server tasks
        var task1 = SimulateServerAsync("Server1", cts.Token);
        var task2 = SimulateServerAsync("Server2", cts.Token);
        var task3 = SimulateServerAsync("Server3", cts.Token);

        // Store tasks in array
        Task<string>[] tasks = { task1, task2, task3 };

        // Wait for the fastest task to complete
        Task<string> fastest = await Task.WhenAny(tasks);

        // Cancel the other tasks
        cts.Cancel();

        try
        {
            string result = await fastest;
            Console.WriteLine($"\n Fastest response: {result}");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Fastest task was cancelled unexpectedly.");
        }

        Console.WriteLine("\nProgram complete.");
    }

    static async Task<string> SimulateServerAsync(string serverName, CancellationToken token)
    {
        Random rand = new Random(Guid.NewGuid().GetHashCode());
        int delay = rand.Next(1000, 5000); // 1 to 5 seconds

        try
        {
            Console.WriteLine($"{serverName} started. Delay = {delay} ms");
            await Task.Delay(delay, token); // simulate delay with cancellation
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"{serverName} responded after {delay} ms");
            return $"{serverName} response in {delay} ms";
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine($"{serverName} was cancelled.");
            throw;
        }
    }
}
