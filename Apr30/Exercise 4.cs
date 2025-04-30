using System;

class Program
{
    static void Main()
    {
        int number = 1;
        while (true)
        {
            int square = number * number;
            if (square > 100)
            {
                break;
            }

            Console.WriteLine($"Square of {number} is {square}");
            number++;
        }
    }
}
