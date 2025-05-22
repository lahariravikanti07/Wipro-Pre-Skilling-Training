using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Input sentence
        string sentence = "C# is great and C# is fun";

        // Step 2: Split sentence into words (handling case and trimming punctuation if needed)
        var words = sentence
            .Split(new[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLower()); // Optional: make it case-insensitive

        // Step 3: Use LINQ group by to count frequencies
        var wordGroups = from word in words
                         group word by word into g
                         select new { Word = g.Key, Count = g.Count() };

        // Step 4: Print results
        foreach (var group in wordGroups)
        {
            Console.WriteLine($"{group.Word}: {group.Count}");
        }
    }
}
