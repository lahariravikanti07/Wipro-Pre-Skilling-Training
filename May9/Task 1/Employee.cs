using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Creation
            Employee emp1 = new Employee(101, "Alice", "HR", 5000);

            emp1.PrintDetails();

            emp1.UpdateSalary(5500);
            emp1.PrintDetails();

            Console.WriteLine("AnnualSalary: " + emp1.AnnualSalary());
        }
    }
}


//Main() method where object is created and methods are called