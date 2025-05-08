using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a stack of strings
        Stack<string> books = new Stack<string>();

        // Pushing elements onto the stack
        books.Push("C# Programming");
        books.Push("Data Structures");
        books.Push("Machine Learning");

        Console.WriteLine("Books in the stack:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        // Popping an element
        Console.WriteLine("\nPopped: " + books.Pop());

        // Peeking at the top element
        Console.WriteLine("Next on the stack: " + books.Peek());
    }
}