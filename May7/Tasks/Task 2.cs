// Write a method that takes a sentence as input and returns the longest word
// Sample Input: "Learning C# is really interesting"
// Output: "interesting"

using System;

public class Program
{
    public static string
        GetLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }

    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string longest = GetLongestWord(input);
        Console.WriteLine("Longest word: " + longest);
    }
}