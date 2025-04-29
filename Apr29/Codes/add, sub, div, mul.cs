using System;

public class HelloWorld
{
    // Method for Addition
    static int Add(int a , int b)
    {
        return a + b;
    }
    
    // Method for Subtraction
    static int Sub(int a , int b)
    {
        return a - b;
    }
    
    // Method for Division
    static  int Div(int a , int b)
    {
        return a / b;
    }
    
    // Method for Multiplication
    static int Mul(int a  , int b)
    {
        return a * b;
    }

    public static void Main(string[] args)
    {
        int num1 = 20;
        int num2 = 10;

        // Calling the method
        Console.WriteLine("Addition: " + Add(num1, num2));
        Console.WriteLine("Subtraction: " + Sub(num1, num2));
        Console.WriteLine("Division: " + Div(num1, num2));
        Console.WriteLine("Multiplication: " + Mul(num1, num2));
    }
}
