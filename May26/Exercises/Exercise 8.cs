using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Simulate 20 image file names
        var imageFiles = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            imageFiles.Add($"Image_{i}.jpg");
        }

        int totalImages = imageFiles.Count;
        int processedImages = 0;

        // Object to lock during progress update
        object progressLock = new object();

        await Parallel.ForEachAsync(imageFiles, async (image, cancellationToken) =>
        {
            // Simulate processing delay
            await Task.Delay(200, cancellationToken);

            // Thread-safe progress update
            lock (progressLock)
            {
                processedImages++;
                double progress = (double)processedImages / totalImages * 100;
                Console.WriteLine($"Processed {processedImages}/{totalImages} - Progress: {progress:F1}%");
            }
        });

        Console.WriteLine("All images processed.");
    }
}
