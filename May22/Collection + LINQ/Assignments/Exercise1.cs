using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a List<string> called students
        List<string> students = new List<string>();

        // 2. Add 5 names to the list
        students.Add("Alice");
        students.Add("Charlie");
        students.Add("Bob");
        students.Add("Eve");
        students.Add("David");

        // 3. Display all names using a foreach loop
        Console.WriteLine("Original list of student names:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        // 4. Sort the list and display it again
        students.Sort();
        Console.WriteLine("\nSorted list of student names:");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
