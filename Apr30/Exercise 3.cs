using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int reversed = 0;

        while (number != 0)
        {
            int remainder = number % 10;
            reversed = (reversed * 10) + remainder;
            number /= 10;
        }

        Console.WriteLine("Reversed number: " + reversed);
    }
}
