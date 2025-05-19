using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeSalaryManagement
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            EmployeeID = id;
            Name = name;
            Salary = salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee(101, "Alice", 75000),
                new Employee(102, "Bob", 82000),
                new Employee(103, "Charlie", 95000),
                new Employee(104, "Diana", 88000),
                new Employee(105, "Ethan", 72000)
            };

            // Step 2: Find employee with the highest salary
            Employee highestPaid = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: ${highestPaid.Salary}");

            // Step 3: Store EmployeeID and Name in a Dictionary
            Dictionary<int, string> employeeDictionary = new Dictionary<int, string>();
            foreach (var emp in employees)
            {
                employeeDictionary[emp.EmployeeID] = emp.Name;
            }

            // Step 4: Display dictionary contents
            Console.WriteLine("\nEmployee Dictionary (ID -> Name):");
            foreach (var pair in employeeDictionary)
            {
                Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
            }

            // Step 5: Search for employee by ID
            Console.WriteLine("\nEnter an Employee ID to search:");
            if (int.TryParse(Console.ReadLine(), out int searchId))
            {
                if (employeeDictionary.TryGetValue(searchId, out string employeeName))
                {
                    Console.WriteLine($"Employee Found: {employeeName}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
