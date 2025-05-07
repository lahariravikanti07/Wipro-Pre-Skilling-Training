using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create an ArrayList of student names 
        List<string> studentNames = new List<string>();

        // 2. Add 5 names to the list
        studentNames.Add("Alice");
        studentNames.Add("Bob");
        studentNames.Add("Charlie");
        studentNames.Add("Diana");
        studentNames.Add("Ethan");

        // 3. Check if a specific name esixts
        string nameToCheck = "Charlie";
        if (studentNames.Contains(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck} exists in the list.");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} does not exist in the list.");
        }

        // 4. Remove the second name (index 1)
        studentNames.RemoveAt(1);  // Removes "Bob"

        // 5. Display the final list
        Console.WriteLine("Final student list:");
        foreach (string name in studentNames)
        { Console.WriteLine(name);
        }
    }
}