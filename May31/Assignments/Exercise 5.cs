using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string input = Console.ReadLine();

        // Normalize the input
        string cleanedInput = Regex.Replace(input.ToLower(), @"[^\w\s]", ""); // remove punctuation

        // Split into words
        string[] words = cleanedInput.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Word frequency using Dictionary + LINQ
        Dictionary<string, int> wordFrequency = words
            .GroupBy(word => word)
            .ToDictionary(g => g.Key, g => g.Count());

        // Count vowels and consonants
        int vowelCount = 0, consonantCount = 0;
        foreach (char c in cleanedInput.Replace(" ", ""))
        {
            if ("aeiou".Contains(c))
                vowelCount++;
            else if (char.IsLetter(c))
                consonantCount++;
        }

        // Longest and shortest word
        string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
        string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();

        // Output results
        Console.WriteLine("\n--- Analysis Result ---");

        Console.WriteLine("\nWord Frequencies:");
        foreach (var pair in wordFrequency.OrderByDescending(p => p.Value))
            Console.WriteLine($"{pair.Key}: {pair.Value}");

        Console.WriteLine($"\nVowels: {vowelCount}");
        Console.WriteLine($"Consonants: {consonantCount}");

        Console.WriteLine($"\nLongest Word: {longestWord}");
        Console.WriteLine($"Shortest Word: {shortestWord}");
    }
}
