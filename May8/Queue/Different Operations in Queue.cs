using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a queue of strings
        Queue<string> queue = new Queue<string>();

        // Enqueue elements
        queue.Enqueue("Amit");
        queue.Enqueue("Neha");
        queue.Enqueue("Ravi");
        queue.Enqueue("Priya");

        Console.WriteLine("Queue Elements:");
        foreach (var name in queue)
        {
            Console.WriteLine(name);
        }

        // Dequeue element
        Console.WriteLine("\nDequeued: " + queue.Dequeue());

        // Peek at the front element
        Console.WriteLine("Next in line: " + queue.Peek());
    }
}