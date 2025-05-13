using System;
using System.Collections.Generic;

namespace Linq_Practice.Practice1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set;  }
        public int Age { get; set;  }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employeeArray = {
                new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 18 },
                new Employee() { EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
                new Employee() { EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
                new Employee() { EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
                new Employee() { EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
                new Employee() { EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
                new Employee() { EmployeeID = 7, EmployeeName = "Rob", Age = 19 },
            };

            // Use LINQ to find teenager Employees
            Employee[] teenAgeerEmployees = employeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

            // Use LINQ to find first Employee whose name is Bill
            Employee bill = employeeArray.Where(s=> s.EmployeeName == "Bill").FirstOrDefault();

            // Use LINQ to find Employee whose EmployeeID is 5
            Employee Employee5 = employeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();
        }
    }
}

// Here the number of lines are reduced due to the use of LAMBDA FUNCTION