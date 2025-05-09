using System;

namespace EmployeeManagement
{
    // Class Definition
    public class Employee
    {
        // Fields
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        // Constructor
        public Employee(int id, string name, string dept, double salary)
        {
            EmployeeID = id;
            Name = name;
            Department = dept;
            Salary = salary;
        }

        // Prints employee details
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {EmployeeID}, Name {Name}, Department: {Department}, Salary: {Salary}");  
        }

        // Updates salary
        public void UpdateSalary(double newSalary)
        {
            Salary = newSalary;
            Console.WriteLine("Salary updated.");
        }

        // Calculates annual salary
        public double AnnualSalary()
        {
            return Salary * 12;
        }
    }
}

//This file should only contain the Employee class