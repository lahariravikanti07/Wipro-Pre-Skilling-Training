using System;

class Program
{
    // Recursive function to find the sum of digits
    static int SumOfDigits(int number)
    {
        // Base case: if number is 0, return 0
        if (number == 0)
        {
            return 0;
        }

        // Recursive case: sum the last digit and call the function on the remaining digits
        return number % 10 + SumOfDigits(number / 10);
    }

    static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Call the recursive function and display the result
        int sum = SumOfDigits(number);
        Console.WriteLine("The sum of digits is: " + sum);
    }
}
