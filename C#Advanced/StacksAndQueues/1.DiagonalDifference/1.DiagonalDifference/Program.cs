using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] rowOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rowOfMatrix[j];
                }
            }

            int primatyDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primatyDiagonal += matrix[i, i];
            }

            int col = 0;
            for (int row = n - 1; row >= 0; row--)
            {
                secondaryDiagonal += matrix[row, col];
                col++;
            }

            Console.WriteLine(Math.Abs(primatyDiagonal - secondaryDiagonal));

        }
    }
}
