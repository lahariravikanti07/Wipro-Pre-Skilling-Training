using System;

class Program
{
    // Recursive function to count the number of zeroes
    static int CountZeroes(int number)
    {
        // Base case: if the number is 0, return 1
        if (number == 0)
            return 1;

        // If the number is less than 10, return 0 if it's not zero
        if (number < 10)
            return 0;

        // Recursive case: check the last digit and recurse on the remaining digits
        int lastDigit = number % 10;
        return (lastDigit == 0 ? 1 : 0) + CountZeroes(number / 10);
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int zeroesCount = CountZeroes(number);
        Console.WriteLine($"Number of zeroes in {number}: {zeroesCount}");
    }
}

