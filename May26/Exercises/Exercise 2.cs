using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentRankList
{
    class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Marks = 92, Grade = "A" },
                new Student { Name = "Bob", Marks = 85, Grade = "B" },
                new Student { Name = "Charlie", Marks = 88, Grade = "B" },
                new Student { Name = "Diana", Marks = 95, Grade = "A" },
                new Student { Name = "Ethan", Marks = 76, Grade = "C" },
                new Student { Name = "Fiona", Marks = 89, Grade = "B" },
                new Student { Name = "George", Marks = 81, Grade = "C" },
                new Student { Name = "Hannah", Marks = 90, Grade = "A" },
                new Student { Name = "Ian", Marks = 70, Grade = "D" },
                new Student { Name = "Jane", Marks = 84, Grade = "B" }
            };

            // Sort students by Marks in descending order
            var sortedByMarks = students.OrderByDescending(s => s.Marks);

            Console.WriteLine("=== Sorted by Marks (Descending) ===");
            foreach (var student in sortedByMarks)
            {
                Console.WriteLine($"{student.Name} - Marks: {student.Marks}, Grade: {student.Grade}");
            }

            Console.WriteLine("\n=== Grouped by Grade ===");
            var groupedByGrade = students.GroupBy(s => s.Grade);
            foreach (var group in groupedByGrade)
            {
                Console.WriteLine($"Grade: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  {student.Name} - Marks: {student.Marks}");
                }
            }

            Console.WriteLine("\n=== Top 3 Students ===");
            var top3Students = sortedByMarks.Take(3);
            foreach (var student in top3Students)
            {
                Console.WriteLine($"{student.Name} - Marks: {student.Marks}, Grade: {student.Grade}");
            }
        }
    }
}
