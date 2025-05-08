using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary to store student IDs and names
        Dictionary<int, string> students = new Dictionary<int, string>();

        // Adding elements
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        // Accessing values using keys
        Console.WriteLine("Student with ID 102: " + students[102]);

        // Looping through the dictionary
        foreach (var pair in students)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }
    }
}