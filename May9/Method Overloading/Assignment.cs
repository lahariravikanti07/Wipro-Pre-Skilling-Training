using System;

namespace ConsoleApp2
{
    class Calculator
    {
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}

using System;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        Calculator cal = new Calculator();

        Console.WriteLine("SUBTRACTION");
        Console.WriteLine($"Subtraction of 2 integers : {cal.Sub(7, 5)}");
        Console.WriteLine($"Subtraction of 3 integers : {cal.Sub(12, 8, 4)}");
        Console.WriteLine($"Subtraction of 2 doubles : {cal.Sub(6.7, 2.4)}\n");

        
        Console.WriteLine("MULTIPLICATION");
        Console.WriteLine($"Multiplication of 2 integers : {cal.Mul(3, 6)}");
        Console.WriteLine($"Multiplication of 3 integers : {cal.Mul(3, 5, 7)}");
        Console.WriteLine($"Multiplication of 2 doubles : {cal.Mul(2.6, 4.3)}\n");
    }
}