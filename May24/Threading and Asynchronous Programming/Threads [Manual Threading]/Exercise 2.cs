using System;
using System.Threading;

class Program
{
    // Simulate task 1: Printing
    static void Task1()
    {
        Console.WriteLine("Task 1: Printing...");
        Thread.Sleep(1000); // Simulate work
        Console.WriteLine("Task 1 completed.");
    }

    // Simulate task 2: Computing
    static void Task2()
    {
        Console.WriteLine("Task 2: Computing...");
        long sum = 0;
        for (int i = 0; i < 1000000; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Task 2 completed. Sum = {sum}");
    }

    // Simulate task 3: Waiting
    static void Task3()
    {
        Console.WriteLine("Task 3: Waiting...");
        Thread.Sleep(2000); // Simulate longer work
        Console.WriteLine("Task 3 completed.");
    }

    static void Main()
    {
        // Create threads
        Thread thread1 = new Thread(Task1);
        Thread thread2 = new Thread(Task2);
        Thread thread3 = new Thread(Task3);

        // Start threads
        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for all threads to finish
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("All tasks done.");
    }
}
