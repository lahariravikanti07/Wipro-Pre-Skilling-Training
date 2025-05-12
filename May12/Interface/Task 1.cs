using System;

// Step 1: Define the interface
interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    int Divide(int a, int b);
}

// Step 2: Implement the interface in a class
class Simplecalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        // Basic check to avoid dividion by zero
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }
}

// UStep 3: se the class in Main method
class Program{
    static void Main()
    {
        Simplecalculator calculator = new Simplecalculator();

        Console.WriteLine("Add: " + calculator.Add(10, 5));
        Console.WriteLine("Subtract: " + calculator.Subtract(10, 5));
        Console.WriteLine("Multiply: " + calculator.Multiply(10, 5));
        Console.WriteLine("Divide: " + calculator.Divide(10, 5));
    }
}