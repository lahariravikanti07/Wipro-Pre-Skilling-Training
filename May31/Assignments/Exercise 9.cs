using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching weather data...");

        // Start timer
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Start all tasks concurrently
        Task<string> city1Task = FetchWeatherAsync("New York", 2000);
        Task<string> city2Task = FetchWeatherAsync("London", 3000);
        Task<string> city3Task = FetchWeatherAsync("Tokyo", 2500);

        // Wait for all to complete
        string[] results = await Task.WhenAll(city1Task, city2Task, city3Task);

        // Stop timer
        stopwatch.Stop();

        // Print results
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }

        Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task<string> FetchWeatherAsync(string city, int simulatedDelay)
    {
        await Task.Delay(simulatedDelay); // Simulate API delay
        return $"Weather data for {city} (after {simulatedDelay} ms)";
    }
}
