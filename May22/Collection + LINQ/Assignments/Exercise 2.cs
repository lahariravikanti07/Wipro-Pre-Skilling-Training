using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a dictionary
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // Step 2: Add 3 contacts
        phoneBook.Add("John", "123-456-7890");
        phoneBook.Add("Rohan", "987-654-3210");
        phoneBook.Add("Charan", "555-123-4567");

        // Step 3: Display all contacts
        Console.WriteLine("Phone Book Contacts:");
        foreach (KeyValuePair<string, string> contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }

        // Step 4: Ask user for a name and display the phone number if found
        Console.Write("\nEnter a name to search: ");
        string nameToSearch = Console.ReadLine();

        if (phoneBook.ContainsKey(nameToSearch))
        {
            Console.WriteLine($"Phone number for {nameToSearch}: {phoneBook[nameToSearch]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
