using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>();

        // Adding elements
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(15);

        // Printing elements
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}