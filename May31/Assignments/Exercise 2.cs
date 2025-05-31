using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDirectory
{
    class Program
    {
        // Define the Employee class
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
        }

        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { ID = 1, Name = "Alice", Department = "HR", Salary = 55000 },
                new Employee { ID = 2, Name = "Bob", Department = "IT", Salary = 75000 },
                new Employee { ID = 3, Name = "Charlie", Department = "IT", Salary = 82000 },
                new Employee { ID = 4, Name = "Diana", Department = "Finance", Salary = 65000 },
                new Employee { ID = 5, Name = "Ethan", Department = "HR", Salary = 48000 },
                new Employee { ID = 6, Name = "Fiona", Department = "Finance", Salary = 71000 }
            };

            // 1. Filter employees by department (e.g., IT)
            string filterDept = "IT";
            var filteredEmployees = employees
                .Where(e => e.Department == filterDept);

            Console.WriteLine($"Employees in Department: {filterDept}");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"{emp.Name} - ${emp.Salary}");
            }

            // 2. Sort all employees by salary in descending order
            var sortedEmployees = employees
                .OrderByDescending(e => e.Salary);

            Console.WriteLine("\nEmployees sorted by Salary (Descending):");
            foreach (var emp in sortedEmployees)
            {
                Console.WriteLine($"{emp.Name} - {emp.Department} - ${emp.Salary}");
            }

            // 3. Find average salary per department
            var avgSalaryPerDept = employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                });

            Console.WriteLine("\nAverage Salary per Department:");
            foreach (var dept in avgSalaryPerDept)
            {
                Console.WriteLine($"{dept.Department}: ${dept.AverageSalary:F2}");
            }
        }
    }
}
