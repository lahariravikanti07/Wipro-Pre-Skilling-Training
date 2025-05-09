using System;

namespace ConsoleApp2{
    class Employee
    {
        public virual void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }

    class Manager : Employee{
        public override void Work()
        {
            Console.WriteLine("Manager is supervising.");
        }
    }
}

using System;
using ConsoleApp2;

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Work();  // Calls base method
        
        Manager mgr = new Manager();
        mgr.Work();  // Calls overridden method
         
        // Polymorphism
        Employee polyEmp = new Manager();
        polyEmp.Work();  // Calls overridden method
    }
}