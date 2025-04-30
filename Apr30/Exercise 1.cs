using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a number from 1 to 12
        Console.Write("Enter a month number (1-12): ");
        
        // Read user input and convert it to an integer
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        // Array of month names
        string[] months = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        // Check if the input is valid
        if (monthNumber >= 1 && monthNumber <= 12)
        {
            // Loop through the array to find the month
            for (int i = 0; i < 12; i++)
            {
                if (i == monthNumber - 1)
                {
                    Console.WriteLine("The month is: " + months[i]);
                }
            }
        }
        else
        {
            // Show error if number is not between 1 and 12
            Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
        }
    }
}
