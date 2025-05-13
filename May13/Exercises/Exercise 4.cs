using System;

namespace EmployeeHierarchy
{
    // 1. Abstract class
    abstract class Employee
    {
        // Abstract method
        public abstract void CalculateSalary();

        // Concrete method
        public void ShowBasicInfo()
        {
            Console.WriteLine("Employee details");
        }
    }

    // 2. Derived class: FullTimeEmployee
    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary: Basic + Allowance");
        }
    }

    // 2. Derived class: PartTimeEmployee
    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary: Hourly rate * Hours worked");
        }
    }

    // 3. Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Employee reference to FullTimeEmployee
            Employee emp1 = new FullTimeEmployee();
            emp1.ShowBasicInfo();
            emp1.CalculateSalary();

            Console.WriteLine();

            // Employee reference to PartTimeEmployee
            Employee emp2 = new PartTimeEmployee();
            emp2.ShowBasicInfo();
            emp2.CalculateSalary();
        }
    }
}