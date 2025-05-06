// Write a method that prints a triangle of n rows using *.
// Sample Input: n = 4
// Output: *
//         **
//         ***
//         ****

using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 6; i++)
        {
            for (int j = 1; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
