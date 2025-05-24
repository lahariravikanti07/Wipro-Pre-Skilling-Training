using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Fetching temperatures...\n");

        Task<int> temp1 = GetTemperatureAsync("New York");
        Task<int> temp2 = GetTemperatureAsync("London");
        Task<int> temp3 = GetTemperatureAsync("Tokyo");

        int[] temperatures = await Task.WhenAll(temp1, temp2, temp3);

        Console.WriteLine($"New York: {temperatures[0]}°C");
        Console.WriteLine($"London: {temperatures[1]}°C");
        Console.WriteLine($"Tokyo: {temperatures[2]}°C");
    }

    static async Task<int> GetTemperatureAsync(string city)
    {
        Random rnd = new Random();
        int delay = rnd.Next(1000, 3000); // Delay between 1-3 seconds
        await Task.Delay(delay);

        int temp = rnd.Next(-10, 40); // Random temperature between -10 and 40
        Console.WriteLine($"{city} temperature retrieved after {delay} ms");
        return temp;
    }
}
