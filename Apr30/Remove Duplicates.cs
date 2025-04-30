using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample array with duplicates
        int[] numbers = { 1, 2, 3, 4, 4, 5, 6, 6, 7 };

        // Remove duplicates using LINQ Distinct method
        var distinctNumbers = numbers.Distinct().ToArray();

        Console.WriteLine("Array after removing duplicates:");
        foreach (var number in distinctNumbers)
        {
            Console.Write(number + " ");
        }
    }
}
