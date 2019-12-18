using System;
using System.Collections.Generic;
using System.Linq;

namespace _Demo_CSharpAdvancedExam23October2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] garden = new string[rows][];
            Dictionary<string, int> vegetables = new Dictionary<string, int>
            {
                { "Carrots", 0},
                { "Potatoes", 0},
                { "Lettuce", 0}
            };
            int harmetVegetables = 0;


            for (int i = 0; i < rows; i++)
            {
                garden[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of Harvest")
                {
                    break;
                }

                string[] tokens = command.Split();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);

                if (tokens[0] == "Harvest")
                {
                    if (garden.Length > row && garden[row].Length > col)
                    {
                        if (garden[row][col] == "C")
                        {
                            vegetables["Carrots"]++;
                            garden[row][col] = " ";
                        }
                        else if (garden[row][col] == "P")
                        {
                            vegetables["Potatoes"]++;
                            garden[row][col] = " ";
                        }
                        else if (garden[row][col] == "L")
                        {
                            vegetables["Lettuce"]++;
                            garden[row][col] = " ";
                        }
                    }
                }
                else if (tokens[0] == "Mole")
                {
                    if (garden.Length > row && garden[row].Length > col)
                    {
                        if (tokens[3] == "up")
                        {
                            for (int i = row; i > 0; i -= 2)
                            {
                                if (garden[i][col] != " ")
                                {
                                    garden[i][col] = " ";
                                    harmetVegetables++;
                                }
                            }
                        }
                        else if (tokens[3] == "down")
                        {
                            for (int i = row; i < garden.Length; i += 2)
                            {
                                if (garden[i][col] != " ")
                                {
                                    garden[i][col] = " ";
                                    harmetVegetables++;
                                }
                            }
                        }
                        else if (tokens[3] == "left")
                        {
                            for (int i = col; i > 0; i -= 2)
                            {
                                if (garden[row][i] != " ")
                                {
                                    garden[row][i] = " ";
                                    harmetVegetables++;
                                }
                            }
                        }
                        else if (tokens[3] == "right")
                        {
                            for (int i = col; i < garden[row].Length; i += 2)
                            {
                                if (garden[row][i] != " ")
                                {
                                    garden[row][i] = " ";
                                    harmetVegetables++;
                                }
                            }
                        }
                    }

                }
            }

            for (int row = 0; row < garden.Length; row++)
            {
                Console.WriteLine(string.Join(" ", garden[row]).TrimEnd());
            }

            foreach (var vegetable in vegetables)
            {
                Console.WriteLine($"{vegetable.Key}: {vegetable.Value}");
            }

            Console.WriteLine($"Harmed vegetables: {harmetVegetables}");
        }
    }
}


