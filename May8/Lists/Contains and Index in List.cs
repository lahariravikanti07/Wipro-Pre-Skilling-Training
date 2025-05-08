using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 20, 40, 60, 80, 100 };

        int index = numbers.IndexOf(60);
        Console.WriteLine("Index of 60: " + index);

        bool contains = numbers.Contains(40);
        Console.WriteLine("Contains 40: " + contains);
    }
}