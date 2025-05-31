using System;

class Calculator
{
    // Add methods
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static float Add(float a, float b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    // Subtract methods
    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static float Subtract(float a, float b)
    {
        return a - b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Multiply methods
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static float Multiply(float a, float b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the operation (Add/Subtract/Multiply): ");
        string operation = Console.ReadLine();

        Console.WriteLine("Choose data type (int/float/double): ");
        string dataType = Console.ReadLine();

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        switch (dataType.ToLower())
        {
            case "int":
                int aInt = int.Parse(input1);
                int bInt = int.Parse(input2);
                PerformOperation(operation, aInt, bInt);
                break;

            case "float":
                float aFloat = float.Parse(input1);
                float bFloat = float.Parse(input2);
                PerformOperation(operation, aFloat, bFloat);
                break;

            case "double":
                double aDouble = double.Parse(input1);
                double bDouble = double.Parse(input2);
                PerformOperation(operation, aDouble, bDouble);
                break;

            default:
                Console.WriteLine("Invalid data type selected.");
                break;
        }
    }

    static void PerformOperation(string operation, int a, int b)
    {
        switch (operation.ToLower())
        {
            case "add":
                Console.WriteLine("Result: " + Calculator.Add(a, b));
                break;
            case "subtract":
                Console.WriteLine("Result: " + Calculator.Subtract(a, b));
                break;
            case "multiply":
                Console.WriteLine("Result: " + Calculator.Multiply(a, b));
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }

    static void PerformOperation(string operation, float a, float b)
    {
        switch (operation.ToLower())
        {
            case "add":
                Console.WriteLine("Result: " + Calculator.Add(a, b));
                break;
            case "subtract":
                Console.WriteLine("Result: " + Calculator.Subtract(a, b));
                break;
            case "multiply":
                Console.WriteLine("Result: " + Calculator.Multiply(a, b));
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }

    static void PerformOperation(string operation, double a, double b)
    {
        switch (operation.ToLower())
        {
            case "add":
                Console.WriteLine("Result: " + Calculator.Add(a, b));
                break;
            case "subtract":
                Console.WriteLine("Result: " + Calculator.Subtract(a, b));
                break;
            case "multiply":
                Console.WriteLine("Result: " + Calculator.Multiply(a, b));
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}
