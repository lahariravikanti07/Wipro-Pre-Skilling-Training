using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a Dictionary to store names and phone numbers
        Dictionary<string, string> phoneDirectory = new Dictionary<string, string>();

        // Add 5 contacts
        phoneDirectory.Add("Alice", "123-456-7890");
        phoneDirectory.Add("Bob", "234-567-8901");
        phoneDirectory.Add("Charlie", "345-678-9012");
        phoneDirectory.Add("Diana", "456-789-0123");
        phoneDirectory.Add("Ethan", "567-890-1234");

        // Update a phone number for a specific name
        string nameToUpdate = "Bob";
        if (phoneDirectory.ContainsKey(nameToUpdate))
        {
            phoneDirectory[nameToUpdate] = "999-999-9999";
            Console.WriteLine($"Updated phone number for {nameToUpdate}.");
        }

        // Check if a particular name exists
        string nameToCheck = "Alice";
        if (phoneDirectory.ContainsKey(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck} exists in the directory.");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} does not exist in the directory.");
        }

        // Print all the contacts
        Console.WriteLine("\nPhone Directory:");
        foreach (var contact in phoneDirectory)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }
    }
}