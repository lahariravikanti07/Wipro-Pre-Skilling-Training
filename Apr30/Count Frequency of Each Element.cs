using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        Console.WriteLine("Element frequencies:");
        foreach (KeyValuePair<int, int> pair in frequency)
        {
            Console.WriteLine($"Element {pair.Key} appears {pair.Value} times");
        }
    }
}
