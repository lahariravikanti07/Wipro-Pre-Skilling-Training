using System;

namespace ConsoleApp2
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
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

        Console.WriteLine($"Addition of 2 integers : {cal.Add(2, 4)}");

        Console.WriteLine($"Addition of 3 integers : {cal.Add(2, 4, 6)}");

        Console.WriteLine($"Addition of 2 doubles : {cal.Add(2.2, 4.4)}");
    }
}