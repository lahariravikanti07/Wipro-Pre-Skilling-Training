using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static Queue<string> taskQueue = new Queue<string>();
    static object queueLock = new object();
    static bool isRunning = true;

    static void Main(string[] args)
    {
        // Start worker thread
        Thread workerThread = new Thread(ProcessTasks);
        workerThread.Start();

        // Enqueue 5 tasks
        for (int i = 1; i <= 5; i++)
        {
            lock (queueLock)
            {
                string task = $"Task {i}";
                taskQueue.Enqueue(task);
                Console.WriteLine($"[Main] Enqueued: {task}");
            }
            Thread.Sleep(500); // Simulate time delay between task submissions
        }

        // Wait until queue is empty
        while (true)
        {
            lock (queueLock)
            {
                if (taskQueue.Count == 0)
                {
                    isRunning = false; // Signal worker thread to exit
                    break;
                }
            }
            Thread.Sleep(100); // Check again shortly
        }

        // Wait for worker to finish
        workerThread.Join();
        Console.WriteLine("[Main] All tasks processed. Exiting.");
    }

    static void ProcessTasks()
    {
        while (isRunning || taskQueue.Count > 0)
        {
            string task = null;
            lock (queueLock)
            {
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                    Console.WriteLine($"[Worker] Dequeued: {task}");
                }
            }

            if (task != null)
            {
                // Simulate task processing
                Console.WriteLine($"[Worker] Processing {task}...");
                Thread.Sleep(1000);
                Console.WriteLine($"[Worker] Finished {task}");
            }
            else
            {
                Thread.Sleep(100); // Wait for new tasks
            }
        }

        Console.WriteLine("[Worker] No more tasks. Exiting thread.");
    }
}
