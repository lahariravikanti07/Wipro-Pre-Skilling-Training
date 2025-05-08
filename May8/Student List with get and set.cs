using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1,  Name = "Alice" },
            new Student { ID = 2, Name = "Bob"}
        };

        // Adding another student
        students.Add(new Student { ID = 3, Name = "Charllie " });

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
        }
    }
}