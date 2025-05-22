using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create dictionary with Employee ID as key and Salary as value
        Dictionary<int, decimal> employeeSalaries = new Dictionary<int, decimal>();

        // Step 2: Add 4–5 employees
        employeeSalaries.Add(101, 55000.50m);
        employeeSalaries.Add(102, 62000.00m);
        employeeSalaries.Add(103, 47000.75m);
        employeeSalaries.Add(104, 88000.20m);
        employeeSalaries.Add(105, 76000.90m);

        // Step 3: Ask the user to enter an Employee ID
        Console.Write("Enter Employee ID to lookup salary: ");
        string input = Console.ReadLine();

        // Step 4: Try to parse and find the salary
        if (int.TryParse(input, out int employeeId))
        {
            if (employeeSalaries.TryGetValue(employeeId, out decimal salary))
            {
                Console.WriteLine($"Employee ID: {employeeId}, Salary: ${salary}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric Employee ID.");
        }
    }
}
