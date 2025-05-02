using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a string or number to check if it's a palindrome: ");
        string input = Console.ReadLine();

        // Remove whitespace and convert to lowercase for uniform comparison
        string processedInput = input.Replace(" ", "").ToLower();

        // Reverse the string
        char[] charArray = processedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        // Compare original and reversed strings
        if (processedInput == reversed)
        {
            Console.WriteLine($"\"{input}\" is a Palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is NOT a Palindrome.");
        }
    }
}
