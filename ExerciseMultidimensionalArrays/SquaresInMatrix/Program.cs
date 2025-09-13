using System;
using System.Linq;

namespace SquaresInMatrix;
class Program
{
    static void Main(string[] args)
    {
        int[] sizes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

       

        int rows = sizes[0];
        int cols = sizes[1];


        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            var currentRow = Console
                .ReadLine()
                .Split()
                .ToArray();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currentRow[col];
            }
        }


        if (rows < 2 || cols < 2)
        {
            Console.WriteLine(0);
            return;
        }

        int sum = 0;
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                bool found =
                    matrix[row, col] ==
                    matrix[row, col + 1] &&
                    matrix[row, col] ==
                    matrix[row + 1, col] &&
                    matrix[row, col] ==
                    matrix[row + 1, col + 1];

                if (found)
                {
                    sum++;
                }

            }
        }
        Console.WriteLine(sum);
    }
}

