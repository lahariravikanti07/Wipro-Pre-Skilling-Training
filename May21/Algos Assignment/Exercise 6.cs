using System;
using System.Collections.Generic;

class GreedyCoinChange
{
    static void Main()
    {
        // Available denominations (descending order for greedy approach)
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        // Input: amount to be changed
        Console.Write("Enter the amount: ");
        int amount = int.Parse(Console.ReadLine());

        List<int> coinsUsed = new List<int>();
        int totalCoins = 0;

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinsUsed.Add(coin);
                totalCoins++;
            }
        }

        // Output: list of coins used and total count
        Console.WriteLine("Coins used: " + string.Join(", ", coinsUsed));
        Console.WriteLine("Total coins: " + totalCoins);
    }
}
