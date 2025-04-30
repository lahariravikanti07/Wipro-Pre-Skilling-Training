using System;

class Program
{
    static int CountVowels(string input)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";
        
        foreach (char c in input)
        {
            if(vowels.Contains(c))
            count++;
        }
        return count;
    }
    
    static void Main()
    {
        string sentence = "Programming is fun!";
        Console.WriteLine("Number of vowels: " + CountVowels(sentence));
    }
}