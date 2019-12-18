using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem03JediGalaxy
{
    public class Runner
    {
        public static void Run()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = dimestions[0];
            int col = dimestions[1];

            int[,] matrix = new int[row, col];

            int value = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            string command = Console.ReadLine();

            long sum = 0;

            while (command != "Let the Force be with you")
            {
                int[] ivoS = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evil = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int xE = evil[0];
                int yE = evil[1];

                while (xE >= 0 && yE >= 0)
                {
                    if (xE >= 0 && xE < matrix.GetLength(0) && yE >= 0 && yE < matrix.GetLength(1))
                    {
                        matrix[xE, yE] = 0;
                    }
                    xE--;
                    yE--;
                }

                int xI = ivoS[0];
                int yI = ivoS[1];

                while (xI >= 0 && yI < matrix.GetLength(1))
                {
                    if (xI >= 0 && xI < matrix.GetLength(0) && yI >= 0 && yI < matrix.GetLength(1))
                    {
                        sum += matrix[xI, yI];
                    }

                    yI++;
                    xI--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
