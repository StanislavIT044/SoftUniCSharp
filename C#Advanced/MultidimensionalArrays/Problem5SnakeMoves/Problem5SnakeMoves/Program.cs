using System;
using System.Linq;

namespace Problem5SnakeMoves
{
    class Program
    {
        static void Main()
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            string[,] matrix = new string[rowsAndCols[0], rowsAndCols[1]];
            int counter = 0;

            for (int row = 0; row < rowsAndCols[0]; row++)
            {
                if (row % 2 == 0 || row == 0)
                {
                    for (int col = 0; col < rowsAndCols[1]; col++)
                    {
                        matrix[row, col] = snake[counter].ToString();
                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = rowsAndCols[1] - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[counter].ToString();
                        counter++;
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}