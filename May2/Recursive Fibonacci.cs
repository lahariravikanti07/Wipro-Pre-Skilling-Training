using System;

class Program
{
    // Recursive function to calculate Fibonacci numbers
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of Fibonacci terms: ");
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < count; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
