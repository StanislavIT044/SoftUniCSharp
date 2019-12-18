using System;
using System.Linq;

namespace Problem4MatrixShuffling
{
    class Program
    {
        static void Main()
        {
            int[] matrixRolsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[matrixRolsAndCols[0], matrixRolsAndCols[1]];

            for (int rows = 0; rows < matrixRolsAndCols[0]; rows++)
            {
                string[] row = Console.ReadLine().Split();
                for (int cols = 0; cols < matrixRolsAndCols[1]; cols++)
                {
                    matrix[rows, cols] = row[cols];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] splitCommand = command.Split();
                if (splitCommand.Count() == 5)
                {
                    int[] indexes =
                    {
                        int.Parse(splitCommand[1]), int.Parse(splitCommand[2]), int.Parse(splitCommand[3]), int.Parse(splitCommand[4])
                    };

                    if (splitCommand[0] == "swap" &&
                        indexes[0] <= matrix.GetLength(0) &&
                        indexes[1] <= matrix.GetLength(1) &&
                        indexes[2] <= matrix.GetLength(0) &&
                        indexes[3] <= matrix.GetLength(1))
                    {

                        string firstNum = matrix[indexes[0], indexes[1]];
                        string secoundNum = matrix[indexes[2], indexes[3]];

                        matrix[indexes[0], indexes[1]] = secoundNum;
                        matrix[indexes[2], indexes[3]] = firstNum;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
