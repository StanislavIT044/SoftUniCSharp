using System;
using System.Linq;
using System.Text;

namespace Problem3.MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < rowsAndCols[1]; j++)
                {
                    matrix[i, j] = rowOfMatrix[j];
                }
            }

            int maximalSum = int.MinValue;
            int[,] maximalMatrix = new int[3, 3];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                     matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];


                    if (currentSum > maximalSum)
                    {
                        maximalSum = currentSum;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                maximalMatrix[i, j] = matrix[row + i, col + j];
                            }
                        }

                    }
                }
            }

            Console.WriteLine($"Sum = {maximalSum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (col == 2)
                    {
                        Console.WriteLine(maximalMatrix[row, col]);
                    }
                    else
                    {
                        Console.Write($"{maximalMatrix[row, col]} ");
                    }
                }
            }
        }
    }
}



//matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
//matrix[row + 1, col] + matrix[row + 1, col + 1]) + matrix[row + 1, col + 2] +
//matrix[row + 2, col] + matrix[row + 2, col + 1]) + matrix[row + 2, col + 2] 
//< maximalSum