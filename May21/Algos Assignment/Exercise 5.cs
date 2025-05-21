using System;

class Program
{
    // Recursive method to solve Tower of Hanoi
    static void TowerOfHanoi(int n, char from, char to, char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }

        // Move n-1 disks from source to auxiliary
        TowerOfHanoi(n - 1, from, aux, to);

        // Move the nth disk from source to destination
        Console.WriteLine($"Move disk {n} from {from} to {to}");

        // Move the n-1 disks from auxiliary to destination
        TowerOfHanoi(n - 1, aux, to, from);
    }

    static void Main()
    {
        Console.Write("Enter number of disks: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSteps to solve Tower of Hanoi:\n");
        TowerOfHanoi(n, 'A', 'C', 'B'); // A = source, C = destination, B = auxiliary
    }
}
