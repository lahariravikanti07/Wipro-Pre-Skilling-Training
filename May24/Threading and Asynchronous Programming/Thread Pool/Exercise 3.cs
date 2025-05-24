using System;
using System.Threading;

class Program
{
    // Method to be called by threads in the ThreadPool
    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing item {item} on thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000); // Simulate work with a delay
        Console.WriteLine($"Finished processing item {item}");
    }

    static void Main()
    {
        Console.WriteLine("Queuing tasks to ThreadPool...");

        for (int i = 1; i <= 5; i++)
        {
            // Queue the ProcessItem method with item as state
            ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessItem), i);
        }

        // Give time for all threads to finish before the application exits
        Console.WriteLine("Main thread is waiting for tasks to complete...");
        Thread.Sleep(3000);

        Console.WriteLine("All tasks completed.");
    }
}
