// Write a method that counts the number of words in a sentence (assuming words are separated by space).
// Sample Input: "Learning C# is fun"
// Output: 4 words

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);
        Console.WriteLine($"{wordCount} words");
    }

    static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        //Split the sentence by spaces and remove any empty entries
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
