using System;
using System.Linq;

namespace Problem6JaggedArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] rowOfArray = Console.ReadLine().Split().Select(double.Parse).ToArray();
                jaggedArray[row] = new double[rowOfArray.Length];
                for (int col = 0; col < rowOfArray.Length; col++)
                {
                    jaggedArray[row][col] = rowOfArray[col];
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                if (jaggedArray.Length - 1 > row)
                {
                    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                    {
                        for (int element = 0; element < jaggedArray[row].Length; element++)
                        {
                            jaggedArray[row][element] *= 2;
                            jaggedArray[row + 1][element] *= 2;
                        }
                    }
                    else
                    {
                        for (int element = 0; element < jaggedArray[row].Length; element++)
                        {
                            jaggedArray[row][element] /= 2;
                        }
                        for (int element = 0; element < jaggedArray[row + 1].Length; element++)
                        {
                            jaggedArray[row + 1][element] /= 2;
                        }
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] splitCommand = command.Split();

                if (splitCommand[0] == "Add")
                {
                    int[] index = {
                        int.Parse(splitCommand[1]),
                        int.Parse(splitCommand[2]),
                    };

                    double value = int.Parse(splitCommand[3]);

                    if (jaggedArray.Length >= index[0] && index[0] > -1 && index[1] > -1)
                    {
                        if (jaggedArray[index[0]].Length > index[1] && index[0] > -1 && index[1] > -1)
                        {
                            jaggedArray[index[0]][index[1]] += value;
                        }
                    }
                }
                else if (splitCommand[0] == "Subtract")
                {
                    int[] index = {
                        int.Parse(splitCommand[1]),
                        int.Parse(splitCommand[2]),
                    };

                    double value = int.Parse(splitCommand[3]);

                    if (jaggedArray.Length >= index[0] && index[0] > -1 && index[1] > -1)
                    {
                        if (jaggedArray[index[0]].Length > index[1] && index[0] > -1 && index[1] > -1)
                        {
                            jaggedArray[index[0]][index[1]] -= value;
                        }
                    }
                }

            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
