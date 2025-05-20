using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        Random random = new Random();
        int[] originalArray = new int[20];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.Next(1, 101);
        }

        Console.WriteLine("Original Array: ");
        PrintArray(originalArray);

        // Bubble Sort
        int[] bubbleArray = (int[])originalArray.Clone();
        Stopwatch sw1 = Stopwatch.StartNew();
        BubbleSort(bubbleArray);
        sw1.Stop();
        Console.WriteLine("\nBubble Sort Result:");
        PrintArray(bubbleArray);
        Console.WriteLine($"Time Taken: {sw1.Elapsed.TotalMilliseconds} ms");

        // Selection Sort
        int[] selectionArray = (int[])originalArray.Clone();
        Stopwatch sw2 = Stopwatch.StartNew();
        SelectionSort(selectionArray);
        sw2.Stop();
        Console.WriteLine("\nSelection Sort Result:");
        PrintArray(selectionArray);
        Console.WriteLine($"Time Taken: {sw2.Elapsed.TotalMilliseconds} ms");

        // Insertion Sort
        int[] insertionArray = (int[])originalArray.Clone();
        Stopwatch sw3 = Stopwatch.StartNew();
        InsertionSort(insertionArray);
        sw3.Stop();
        Console.WriteLine("\nInsertion Sort Result:");
        PrintArray(insertionArray);
        Console.WriteLine($"Time Taken: {sw3.Elapsed.TotalMilliseconds} ms");

        Console.WriteLine("\n🧠 Time Complexity Analysis:");
        Console.WriteLine("Bubble Sort: O(n^2)");
        Console.WriteLine("Selection Sort: O(n^2)");
        Console.WriteLine("Insertion Sort: O(n^2), but faster on nearly sorted data");
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            // Swap
            int temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
