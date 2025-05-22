using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 2: Create a list of 6 students
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Marks = 85 },
            new Student { Name = "Bob", Marks = 92 },
            new Student { Name = "Charlie", Marks = 78 },
            new Student { Name = "David", Marks = 90 },
            new Student { Name = "Eva", Marks = 88 },
            new Student { Name = "Frank", Marks = 95 }
        };

        // Step 3: Use LINQ to get the top 3 students by marks
        var top3Students = students
            .OrderByDescending(s => s.Marks)
            .Take(3);

        // Step 4: Print the result
        Console.WriteLine("Top 3 Students by Marks:");
        foreach (var student in top3Students)
        {
            Console.WriteLine($"Name: {student.Name}, Marks: {student.Marks}");
        }
    }
}
