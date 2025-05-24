using System;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting parallel file downloads...");

        // Create stopwatch to measure total download time
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Start all downloads in parallel
        Task[] downloadTasks = new Task[]
        {
            DownloadFileAsync("file1.txt", 2000),
            DownloadFileAsync("file2.jpg", 3000),
            DownloadFileAsync("file3.pdf", 1500)
        };

        // Wait for all downloads to complete
        await Task.WhenAll(downloadTasks);

        // Stop the stopwatch and display total time
        stopwatch.Stop();
        Console.WriteLine($"\nAll downloads completed in {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"Starting download of {fileName}...");
        await Task.Delay(delay); // Simulate download time
        Console.WriteLine($"{fileName} downloaded successfully!");
    }
}