using System;

class PowerCalculator
{
    // Method to calculate power of integers
    public static int CalculatePower(int baseVal, int exponent)
    {
        return (int)Math.Pow(baseVal, exponent);
    }

    // Method to calculate power for doubles
    public static double CalculatePower(double baseVal, double exponent)
    {
        return Math.Pow(baseVal, exponent);
    }

    static void Main(string[] args)
    {
        // Calculate and print 2^3
        int resultInt = CalculatePower(2, 3);
        Console.WriteLine("2^3 = " + resultInt);

        // Calculate and print 5.5^2
        double resultDouble = CalculatePower(5.5, 2);
        Console.WriteLine("5.5^2 = " + resultDouble);
    }
}