using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQStudentAverage
{
    // Step 1: Create Student class
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Add at least 5 students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Ava", Marks = 85 },
                new Student { Name = "Bunny", Marks = 72 },
                new Student { Name = "Evan", Marks = 90 },
                new Student { Name = "Rohan", Marks = 68 },
                new Student { Name = "Jeanie", Marks = 95 }
            };

            // Step 3: Calculate average marks using LINQ
            double averageMarks = students.Average(s => s.Marks);
            Console.WriteLine($"Average Marks: {averageMarks}");

            // Step 4: Count how many students scored above average
            int countAboveAverage = students.Count(s => s.Marks > averageMarks);
            Console.WriteLine($"Number of students who scored above average: {countAboveAverage}");
        }
    }
}
