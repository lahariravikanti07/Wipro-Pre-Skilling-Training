using System;
using System.Collections.Generic;

class NQueensSimplified
{
    static void Main()
    {
        Console.Write("Enter value of N: ");
        int N = int.Parse(Console.ReadLine());
        SolveNQueens(N);
    }

    static void SolveNQueens(int N)
    {
        int[] positions = new int[N];  // positions[i] = column of queen in row i
        PlaceQueen(0, N, positions);
    }

    static void PlaceQueen(int row, int N, int[] positions)
    {
        if (row == N)
        {
            PrintBoard(positions, N);
            return;
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(row, col, positions))
            {
                positions[row] = col;
                PlaceQueen(row + 1, N, positions);
            }
        }
    }

    static bool IsSafe(int row, int col, int[] positions)
    {
        for (int i = 0; i < row; i++)
        {
            int otherCol = positions[i];
            if (otherCol == col || Math.Abs(otherCol - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    static void PrintBoard(int[] positions, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(j == positions[i] ? "Q " : "_ ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
