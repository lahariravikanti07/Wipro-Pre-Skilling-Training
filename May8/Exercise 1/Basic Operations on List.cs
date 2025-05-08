using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a list of employee names
        List<string> employeeNames = new List<string>();

        // 2. Add 5 employees
        employeeNames.Add("Alice");
        employeeNames.Add("Bob");
        employeeNames.Add("Charlie");
        employeeNames.Add("Diana");
        employeeNames.Add("Ethan");

        // Display the current list
        Console.WriteLine("Employees after adding 5:");
        DisplayList(employeeNames);

        // 3. Remove an employee by name
        string employeeToRemove = "Charlie";
        if (employeeNames.Remove(employeeToRemove))
        {
            Console.WriteLine($"\n{employeeToRemove} removed successfully.");
        }
        else
        {
            Console.WriteLine($"\n{employeeToRemove} not found.");
        }

        // 4. Check if a specific name exists
        string searchName = "Diana";
        if (employeeNames.Contains(searchName))
        {
            Console.WriteLine($"\n{searchName} exists in the list.");
        }
        else
        {
            Console.WriteLine($"\n{searchName} does not exist in the list.");
        }

        // Print the total number of employees
        Console.WriteLine($"\nTotal number of employees: {employeeNames.Count}");
    }

    static void DisplayList(List<string> list)
    {
        foreach (string name in list)
        {
            Console.WriteLine("- " + name);
        }
    }
}