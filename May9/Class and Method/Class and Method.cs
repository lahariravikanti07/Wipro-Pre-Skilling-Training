using System;

class Student
{
    // Fields
    public int RollNumber;
    public string Name;
    public int Marks;

    // Method to print student details
    public void PrintDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");

    }
}

class Program
{
    static void Main()
    {
        // Creating an object of Student
        Student student1 = new Student();

        // Assigning values
        student1.RollNumber = 101;
        student1.Name = "Amit";
        student1.Marks = 85;

        // Printing details
        student1.PrintDetails();
    }
}