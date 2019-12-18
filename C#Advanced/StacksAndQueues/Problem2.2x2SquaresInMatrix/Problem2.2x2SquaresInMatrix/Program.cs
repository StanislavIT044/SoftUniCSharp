using System;
using System.Linq;

namespace Problem2._2x2SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            string[,] matrix = new string[rows, cols];
            int counterOfEqualChars = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] lineOfMatrix = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = lineOfMatrix[col];
                }
            }

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row,col] == matrix[row,col+1] && matrix[row,col] == matrix[row+1,col] && matrix[row,col] == matrix[row+1,col+1])
                    {
                        counterOfEqualChars++;
                    }
                }
            }

            Console.WriteLine(counterOfEqualChars);

        }
    }
}
