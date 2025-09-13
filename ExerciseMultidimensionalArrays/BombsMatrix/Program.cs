using System;
using System.Linq;

namespace BombsMatrix;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int[] row = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for(int j = 0; j < n; j++)
            {
                matrix[i, j] = row[j];
            }
        }

        string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        foreach (string bomb in bombs)
        {
            int[] parts = bomb.Split(",").Select(int.Parse).ToArray();
            int row = parts[0];
            int col = parts[1];

            int bombValue = matrix[row, col];

            if(bombValue > 0)
            {
                for (int i = row - 1; i <= row; i++)
                {
                    for (int j = col - 1; j <= col; j++)
                    {
                        if (i >= 0 && i < n && j >= 0 && j < n && matrix[i, j] > 0)
                        {
                            matrix[i, j] -= bombValue;
                        }
                    }
                }
            }
        }

        int aliveCells = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > 0)
                {
                    aliveCells++;
                    sum += matrix[i, j];
                }
            }
        }

        Console.WriteLine($"Alive cells: {aliveCells}");
        Console.WriteLine($"Sum: {sum}");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

