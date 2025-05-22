using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create a list with some repeated numbers
        List<int> numbers = new List<int> { 1, 3, 5, 3, 7, 8, 5, 9, 1, 10, 5 };

        // Step 2: Use LINQ to find numbers that appear more than once
        var duplicates = numbers
                         .GroupBy(n => n)
                         .Where(g => g.Count() > 1)
                         .Select(g => g.Key);

        // Step 3: Print the duplicated numbers
        Console.WriteLine("Duplicate numbers:");
        foreach (var num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}
