using System;
using System.Threading;

class Program
{
    // Flags to control the thread
    static bool pause = false;
    static bool stop = false;

    // ManualResetEvent for better thread control
    static ManualResetEvent pauseEvent = new ManualResetEvent(true);

    static void Main(string[] args)
    {
        Thread workerThread = new Thread(PrintNumbers);
        workerThread.Start();

        Console.WriteLine($"Thread started. State: {workerThread.ThreadState}");

        // Let it run for 2 seconds
        Thread.Sleep(2000);

        // Pause the thread
        pause = true;
        pauseEvent.Reset();
        Console.WriteLine($"Thread paused. State: {workerThread.ThreadState}");

        // Pause for 3 seconds
        Thread.Sleep(3000);

        // Resume the thread
        pause = false;
        pauseEvent.Set();
        Console.WriteLine($"Thread resumed. State: {workerThread.ThreadState}");

        // Let it run for 2 seconds
        Thread.Sleep(2000);

        // Stop the thread
        stop = true;
        Console.WriteLine("Thread stopping...");
        workerThread.Join();
        Console.WriteLine($"Thread stopped. Final state: {workerThread.ThreadState}");
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (stop)
                break;

            pauseEvent.WaitOne(); // Wait here if paused

            Console.WriteLine(i);
            Thread.Sleep(100); // Simulate work
        }
    }
}
