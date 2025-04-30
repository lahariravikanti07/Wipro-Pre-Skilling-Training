using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int square = arr[i] * arr[i];
            Console.WriteLine($"Element {arr.Length - i}: {arr[i]} (Square: {square})");
        }
    }
    
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        PrintArray(numbers);
    }
}