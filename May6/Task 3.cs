// Write a method that returns the second largest element in an integer array.
// Sample Inout: {10, 25, 30, 5, 60}
// Output: Second largest: 30

using System;

class secondlargest
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 25, 30, 5, 60 };
        int first = int.MinValue;
        int second = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second && arr[i] != first)
            {
                second = arr[i];
            }
        }
        Console.WriteLine("Second largest: " + second);
    }
}