using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create a list with at least 10 numbers
        List<int> numbers = new List<int> { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

        // Step 2: Use LINQ to filter even and odd numbers
        List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        List<int> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        // Step 3: Print both lists
        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nOdd Numbers:");
        foreach (int num in oddNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
