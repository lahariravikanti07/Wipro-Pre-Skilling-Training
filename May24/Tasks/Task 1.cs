using System;
using System.Threading;

class program
{
    // Async method to simulate a file download

    static async Task DownloadFileAsync(string fileName, int delayMs)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay(delayMs);     // Simulate time taken to download
        Console.WriteLine($"Completed download: {fileName} ({delayMs}ms)");
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all downloads...\n");

        // Start all downloads concurrently
        Task file1 = DownloadFileAsync("file1.pdf", 3000);
        Task file2 = DownloadFileAsync("file2.jpg", 2000);
        Task file3 = DownloadFileAsync("file3.zip", 4000);

        // Wait for all downloads to complete
        await Task.WhenAll(file1, file2, file3);

        Console.WriteLine("\nAll downloads completed.");
    }
}