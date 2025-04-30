using System;

class LinearSearchProgram
{
    // Function to perform linear search
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Return the index if found
            }
        }
        return -1; // Return -1 if not found
    }

    static void Main()
    {
        // Define an array
        int[] numbers = { 10, 25, 30, 45, 50, 60 };

        // Ask the user to enter the number to search
        Console.Write("Enter the number to search: ");
        int target = int.Parse(Console.ReadLine());

        // Call the search function
        int result = LinearSearch(numbers, target);

        // Output the result
        if (result != -1)
        {
            Console.WriteLine("Number found at index: " + result);
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}
