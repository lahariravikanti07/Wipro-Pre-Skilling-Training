using System;
using System.Collections.Generic;

// Step 1: Interface
public interface IAttendance
{
    void MarkAttendance();
}

// Step 2: Abstract class
public abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public Staff(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }

    public abstract double CalculateSalary();
}

// Step 3: PermanentStaff class
public class PermanentStaff : Staff, IAttendance
{
    public double BasicSalary { get; set; }
    public double Allowance { get; set; }

    public PermanentStaff(int id, string name, string department, double basicSalary, double allowance)
        : base(id, name, department)
    {
        BasicSalary = basicSalary;
        Allowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + Allowance;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"Permanent staff {Name} marked present.");
    }
}

// Step 3: ContractStaff class
public class ContractStaff : Staff, IAttendance
{
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public ContractStaff(int id, string name, string department, double hourlyRate, int hoursWorked)
        : base(id, name, department)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"Contract staff {Name} marked present.");
    }
}

// Step 4: Main method with polymorphism
class Program
{
    static void Main(string[] args)
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff(1, "Alice", "HR", 5000, 1000),
            new ContractStaff(2, "Bob", "IT", 50, 160)
        };

        foreach (Staff staff in staffList)
        {
            Console.WriteLine($"\nID: {staff.Id}, Name: {staff.Name}, Department: {staff.Department}");
            Console.WriteLine($"Salary: {staff.CalculateSalary()}");

            if (staff is IAttendance attendance)
            {
                attendance.MarkAttendance();
            }
        }
    }
}
