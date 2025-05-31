using System;
using System.IO;
using System.Threading;

class MultithreadingFileProcessor
{
    static int totalLines = 0;
    static object lockObject = new object();

    static void Main(string[] args)
    {
        string[] filePaths = { "file1.txt", "file2.txt", "file3.txt" };

        // Step 1: Auto-generate sample files
        GenerateSampleFiles(filePaths);

        // Step 2: Create threads to read each file
        Thread[] threads = new Thread[filePaths.Length];

        for (int i = 0; i < filePaths.Length; i++)
        {
            string path = filePaths[i]; // Prevent closure issue
            threads[i] = new Thread(() => CountLinesInFile(path));
            threads[i].Start();
        }

        // Step 3: Wait for all threads to finish
        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"Total lines across all files: {totalLines}");
    }

    static void GenerateSampleFiles(string[] paths)
    {
        for (int i = 0; i < paths.Length; i++)
        {
            using (StreamWriter writer = new StreamWriter(paths[i]))
            {
                for (int j = 1; j <= (i + 1) * 10; j++) // Write 10, 20, 30 lines
                {
                    writer.WriteLine($"This is line {j} of {paths[i]}");
                }
            }
            Console.WriteLine($"{paths[i]} created with {(i + 1) * 10} lines.");
        }
    }

    static void CountLinesInFile(string filePath)
    {
        try
        {
            int lineCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            lock (lockObject)
            {
                totalLines += lineCount;
            }

            Console.WriteLine($"{filePath} has {lineCount} lines.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading {filePath}: {ex.Message}");
        }
    }
}
