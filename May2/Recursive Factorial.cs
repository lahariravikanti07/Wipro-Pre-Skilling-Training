using System;

class Program
{
    // Recursive method to calculate factorial
    static long Factorial(int n)
    {
        if (n <= 1) // Base case
            return 1;
        else
            return n * Factorial(n - 1); // Recursive call
    }

    static void Main()
    {
        Console.Write("Enter a number to find its factorial: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            long result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is: {result}");
        }
    }
}
