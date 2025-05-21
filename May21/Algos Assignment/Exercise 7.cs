using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FirstNonRepeatingCharacter(input);

        if (result != '\0')
        {
            Console.WriteLine("First non-repeating character: " + result);
        }
        else
        {
            Console.WriteLine("No non-repeating character found.");
        }
    }

    static char FirstNonRepeatingCharacter(string s)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        // Count frequency of each character
        foreach (char c in s)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency[c] = 1;
            }
        }

        // Find the first character with frequency 1
        foreach (char c in s)
        {
            if (frequency[c] == 1)
            {
                return c;
            }
        }

        return '\0'; // Return null character if no non-repeating character is found
    }
}
