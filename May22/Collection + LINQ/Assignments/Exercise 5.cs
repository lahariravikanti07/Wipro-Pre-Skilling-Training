using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupEmployeesByDepartment
{
    // Employee class with Name and Department
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of employees with new names and departments
            List<Employee> employees = new List<Employee>
            {
                new Employee("Sophia", "Marketing"),
                new Employee("Liam", "Marketing"),
                new Employee("Aiden", "Engineering"),
                new Employee("Olivia", "Engineering"),
                new Employee("Mason", "Operations"),
                new Employee("Isabella", "Operations")
            };

            // Using LINQ to group employees by department
            var groupedByDepartment = from emp in employees
                                      group emp by emp.Department;

            // Displaying grouped employees under each department
            foreach (var departmentGroup in groupedByDepartment)
            {
                Console.WriteLine($"Department: {departmentGroup.Key}");
                foreach (var emp in departmentGroup)
                {
                    Console.WriteLine($" - {emp.Name}");
                }
                Console.WriteLine(); // Extra line for clarity between departments
            }
        }
    }
}
