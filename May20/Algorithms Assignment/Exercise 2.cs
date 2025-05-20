using System;
using System.Linq;

class SearchingAlgorithms
{
    // Linear Search Implementation
    public static (int position, int comparisons) LinearSearch(int[] arr, int key)
    {
        int comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return (i, comparisons);
        }
        return (-1, comparisons);
    }

    // Binary Search Implementation
    public static (int position, int comparisons) BinarySearch(int[] arr, int key)
    {
        int left = 0, right = arr.Length - 1;
        int comparisons = 0;

        while (left <= right)
        {
            comparisons++;
            int mid = left + (right - left) / 2;
            if (arr[mid] == key)
                return (mid, comparisons);
            else if (arr[mid] < key)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return (-1, comparisons);
    }

    static void Main()
    {
        Random rand = new Random();

        // Generate sorted list of 50 unique random integers between 1 and 200
        int[] arr = Enumerable.Range(1, 200).OrderBy(x => rand.Next()).Take(50).ToArray();
        Array.Sort(arr);

        // Choose a random element from the list to search
        int key = arr[rand.Next(0, arr.Length)];

        Console.WriteLine("Sorted Array:");
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine($"\nSearching for: {key}");

        // Perform Linear Search
        var (linPos, linComp) = LinearSearch(arr, key);
        Console.WriteLine($"\nLinear Search:\nPosition: {linPos}, Comparisons: {linComp}");

        // Perform Binary Search
        var (binPos, binComp) = BinarySearch(arr, key);
        Console.WriteLine($"\nBinary Search:\nPosition: {binPos}, Comparisons: {binComp}");

        // Compare Efficiency
        Console.WriteLine("\nEfficiency Comparison:");
        Console.WriteLine(linComp > binComp
            ? "Binary Search was more efficient."
            : linComp < binComp
                ? "Linear Search was more efficient."
                : "Both searches had the same number of comparisons.");
    }
}
