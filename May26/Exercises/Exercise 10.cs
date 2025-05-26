using System;
using System.Collections.Generic;
using System.Linq;

class WordFrequencyAnalyzer
{
    static void Main()
    {
        // Step 1: Input paragraph
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();

        // Step 2: Split into words (removing punctuation and using space separators)
        var words = input
            .ToLower()
            .Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        // Step 3: Use Dictionary to count word frequencies
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        // Step 4: Sort and display top 5 most frequent words using LINQ
        var top5Words = wordCount
            .OrderByDescending(pair => pair.Value)
            .Take(5);

        Console.WriteLine("\nTop 5 most frequent words:");
        foreach (var pair in top5Words)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value} times");
        }
    }
}
