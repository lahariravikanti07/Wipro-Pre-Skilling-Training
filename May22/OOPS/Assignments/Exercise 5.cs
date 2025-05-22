using System;
using System.Collections.Generic;

// Step 1: Course Class
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }

    public Course(int id, string title, double fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}

// Step 2: IEnrollable Interface
public interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}

// Step 3: User Class
public class User : IEnrollable
{
    private List<(Course course, double finalFee)> enrolledCourses = new List<(Course, double)>();

    public void Enroll(Course course)
    {
        enrolledCourses.Add((course, course.Fee));
        Console.WriteLine($"Enrolled in {course.Title} at full price: ${course.Fee}");
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = GetDiscount(couponCode);
        double finalFee = course.Fee - (course.Fee * discount);
        enrolledCourses.Add((course, finalFee));
        Console.WriteLine($"Enrolled in {course.Title} with coupon '{couponCode}': Final Fee = ${finalFee}");
    }

    private double GetDiscount(string couponCode)
    {
        // Example coupon codes
        return couponCode switch
        {
            "SAVE10" => 0.10,
            "HALFOFF" => 0.50,
            "DISCOUNT20" => 0.20,
            _ => 0.0
        };
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine("\nEnrolled Courses:");
        foreach (var item in enrolledCourses)
        {
            Console.WriteLine($"Course: {item.course.Title}, Final Fee: ${item.finalFee}");
        }
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Course c1 = new Course(1, "C# Basics", 100);
        Course c2 = new Course(2, "Advanced C#", 200);
        Course c3 = new Course(3, "ASP.NET MVC", 300);

        User user = new User();
        user.Enroll(c1);                           // Full fee
        user.Enroll(c2, "SAVE10");                 // 10% off
        user.Enroll(c3, "HALFOFF");                // 50% off

        user.PrintEnrolledCourses();               // Display all enrolled courses
    }
}
