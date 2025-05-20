using System;

class LCSProgram
{
    // Method to find LCS
    public static Tuple<int, string> LCS(string str1, string str2)
    {
        int m = str1.Length;
        int n = str2.Length;
        int[,] dp = new int[m + 1, n + 1];

        // Build the DP table
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        // Reconstruct the LCS from the dp table
        int index = dp[m, n];
        char[] lcsChars = new char[index];
        int a = m, b = n;

        while (a > 0 && b > 0)
        {
            if (str1[a - 1] == str2[b - 1])
            {
                lcsChars[--index] = str1[a - 1];
                a--;
                b--;
            }
            else if (dp[a - 1, b] > dp[a, b - 1])
                a--;
            else
                b--;
        }

        string lcs = new string(lcsChars);
        return Tuple.Create(dp[m, n], lcs);
    }

    static void Main()
    {
        string str1 = "ABCDGH";
        string str2 = "AEDFHR";

        var result = LCS(str1, str2);

        Console.WriteLine("LCS: " + result.Item2);
        Console.WriteLine("Length: " + result.Item1);

        // Time Complexity Analysis
        Console.WriteLine("\nTime Complexity Analysis:");
        Console.WriteLine("Let m = length of str1, n = length of str2");
        Console.WriteLine("Time Complexity: O(m * n) due to the nested loops filling the dp table.");
        Console.WriteLine("Space Complexity: O(m * n) for storing the dp table.");
    }
}
