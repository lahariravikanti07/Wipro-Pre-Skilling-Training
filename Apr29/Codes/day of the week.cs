using System;

class Program
{
    static void Main()
    {
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Console.Write("Enter a number (1 to 7): ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("Day: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number from 1 to 7.");
        }
    }
}