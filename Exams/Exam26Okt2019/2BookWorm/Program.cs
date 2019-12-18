using System;

namespace _2BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialStr = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[] currentPosition = new int[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 'P')
                    {
                        currentPosition[0] = i;
                        currentPosition[1] = j;
                        break;
                    }
                }
            }

            int[] lastP = new int[2];

            while (true)
            {
                matrix[currentPosition[0], currentPosition[1]] = '-';
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "up")
                {
                    if (currentPosition[0] - 1 < 0)
                    {
                        initialStr = initialStr.Remove(initialStr.Length - 1, 1);
                    }
                    else
                    {
                        lastP = currentPosition;
                        currentPosition[0]--;
                    }
                }
                else if (command == "down")
                {
                    if (currentPosition[0] + 1 >= matrix.GetLength(0))
                    {
                        initialStr = initialStr.Remove(initialStr.Length - 1, 1);
                    }
                    else
                    {
                        lastP = currentPosition;
                        currentPosition[0]++;
                    }
                }
                else if (command == "left")
                {
                    if (currentPosition[1] - 1 < 0)
                    {
                        initialStr = initialStr.Remove(initialStr.Length - 1, 1);
                    }
                    else
                    {
                        lastP = currentPosition;
                        currentPosition[1]--;
                    }
                }
                else if (command == "right")
                {
                    if (currentPosition[0] + 1 >= matrix.GetLength(1))
                    {
                        initialStr = initialStr.Remove(initialStr.Length - 1, 1);
                    }
                    else
                    {
                        lastP = currentPosition;
                        currentPosition[1]++;
                    }
                }

                if (char.IsLetter(matrix[currentPosition[0], currentPosition[1]]))
                {
                    initialStr += matrix[currentPosition[0], currentPosition[1]];
                }
               
                matrix[currentPosition[0], currentPosition[1]] = 'P';
                matrix[lastP[0], lastP[1]] = '-';
            }
            matrix[currentPosition[0], currentPosition[1]] = 'P';


            Console.WriteLine(initialStr);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
