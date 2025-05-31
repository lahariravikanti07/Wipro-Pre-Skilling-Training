using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<int> Marks { get; set; }

    public double Average => Marks.Average();
    public int Highest => Marks.Max();
    public int Lowest => Marks.Min();
}

class Program
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        Dictionary<string, Student> students = new Dictionary<string, Student>();

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"\nEnter name of student #{i + 1}: ");
            string name = Console.ReadLine();

            Console.Write($"Enter number of subjects for {name}: ");
            int subjectCount = int.Parse(Console.ReadLine());

            List<int> marks = new List<int>();
            for (int j = 0; j < subjectCount; j++)
            {
                Console.Write($"Enter marks for subject #{j + 1}: ");
                marks.Add(int.Parse(Console.ReadLine()));
            }

            students[name] = new Student { Name = name, Marks = marks };
        }

        Console.WriteLine("\n=== Student Report ===");
        foreach (var student in students.Values)
        {
            Console.WriteLine($"\nStudent: {student.Name}");
            Console.WriteLine($"Marks: {string.Join(", ", student.Marks)}");
            Console.WriteLine($"Average: {student.Average:F2}");
            Console.WriteLine($"Highest: {student.Highest}");
            Console.WriteLine($"Lowest: {student.Lowest}");
        }

        Console.WriteLine("\n=== Top 3 Scorers (by average) ===");
        var top3 = students.Values
                          .OrderByDescending(s => s.Average)
                          .Take(3);

        int rank = 1;
        foreach (var student in top3)
        {
            Console.WriteLine($"#{rank++}: {student.Name} - Average: {student.Average:F2}");
        }
    }
}
