using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create an ArrayList of integers 
        List<int> numbers = new List<int>();

        Random rand = new Random();

        // Add 10 random numbers between 1 and 50
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rand.Next(1, 51));  // 51 is exclusive
        }

        // Print the original list
        Console.WriteLine("Original List:");
        Console.WriteLine(string.Join(", ", numbers));

        // Sort the list in ascending order
        numbers.Sort();

        // Print the sorted list
        Console.WriteLine("\nSorted List (Ascending):");
        Console.WriteLine(string.Join(", ", numbers));

        // Find and print the maximum and minimum values
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine($"\nMaximum Value: {max}");
        Console.WriteLine($"Minimum Value: {min}");

        // Calculate and print the average of all numbers
        double average = numbers.Average();
        Console.WriteLine($"Average: {average:F2}");
    }
}