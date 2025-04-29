using System;

class Program
{
    static void Main()
    {
        int number = 5;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
