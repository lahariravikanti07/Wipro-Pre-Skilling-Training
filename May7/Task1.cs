// Write a method that takes an integer and prints the frequency of each element.
// Sample Input: {1, 2, 2, 3, 4, 4, 4} 
// Output:
// 1 appears 1 time
// 2 appears 2 times
// 3 appears 1 time
// 4 appears 3 times

using System;
using System.Collections.Generic;

class Program
/ Write a method that takes an integer and prints the frequency of each element.
// Sample Input: {1, 2, 2, 3, 4, 4, 4} 
// Output:
// 1 appears 1 time
// 2 appears 2 times
// 3 appears 1 time
// 4 appears 3 times

using System;
using System.Collections.Generic;

class Program
{
    static void PrintElementFrequencies(int[] array)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count frequencies
        foreach (int num in array)
        {
            if (frequencyMap.ContainsKey(num))
            {  frequencyMap[num]++;
            }
            else 
            {
            frequencyMap[num] = 1;
            }
        }

        // Print frequencies
        Console.WriteLine("Element frequencies:");
        foreach (KeyValuePair<int, int> pair in frequencyMap)
        {
            Console.WriteLine($"Element {pair.Key} appears {pair.Value} time(s)");
        }
    }

    static void Main()
    {
        int[] sampleArray = { 1, 2, 2, 3, 4, 4, 4 };
        PrintElementFrequencies(sampleArray);
    }
}
{
    static void PrintElementFrequencies(int[] array)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        // Count frequencies
        foreach (int num in array)
        {
            if (frequencyMap.ContainsKey(num))
            {  frequencyMap[num]++;
            }
            else 
            {
            frequencyMap[num] = 1;
            }
        }

        // Print frequencies
        Console.WriteLine("Element frequencies:");
        foreach (KeyValuePair<int, int> pair in frequencyMap)
        {
            Console.WriteLine($"Element {pair.Key} appears {pair.Value} time(s)");
        }
    }

    static void Main()
    {
        int[] sampleArray = { 1, 2, 2, 3, 4, 4, 4 };
        PrintElementFrequencies(sampleArray);
    }
}
