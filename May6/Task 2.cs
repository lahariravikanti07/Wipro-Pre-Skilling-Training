// Write a method that calculates the sum of digits in a number.
// Sample INput: 1234
// Output: 10

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine(); // Nullable string

        if (int.TryParse(input, out int number))
        {
            int sum = SumOfDigits(number);
            Console.WriteLine($"Sum of digits in {number} is {sum}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static int SumOfDigits(int number)
    {
        number = Math.Abs(number);
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}