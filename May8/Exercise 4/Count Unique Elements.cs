using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list with 10 numbers, including duplicates
        List<int> numbers = new List<int> { 5, 3, 7, 3, 2, 5, 9, 1, 2, 8 };

        // Use a HashSet to find unique numbers
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        // Print unique numbers
        Console.WriteLine("Unique numbers:");
        foreach (int num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }

        // Count how many unique elements are present
        Console.WriteLine($"Total unique elements: {uniqueNumbers.Count}");
    }
}