using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem5AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers = ForEach(numbers, n => n + 1).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = ForEach(numbers, n => n * 2).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = ForEach(numbers, n => n - 1).ToArray();
                }
                else if (command == "print")
                {
                    Print(numbers);
                }
            }
        }
        static IEnumerable<int> ForEach(IEnumerable<int> collection, Func<int, int> func)
        {
            return collection.Select(x => func(x));
        }

        static void Print(int[] nums)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
