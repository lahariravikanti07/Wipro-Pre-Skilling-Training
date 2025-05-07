// Write a method that takes a sentence and prints all duplicates words.
// Sample Input: "This is a test and this test is fun"
// Output: Duplicate worrds: this, test, is

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is a test and this test is fun";

        // Normalize the sentence
        string[] words = input.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', '\"' },
            StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word)) wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        List<string> duplicates = new List<string>();

        foreach (var pair in wordCount)
        {
            if (pair.Value > 1) duplicates.Add(pair.Key);
        }

        Console.WriteLine("Duplicate words: " + string.Join(",", duplicates));
    }
}