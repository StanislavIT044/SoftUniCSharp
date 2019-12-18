using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            int[] startAndEnd = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int startOf = startAndEnd[0];
            int endOf = startAndEnd[1];

            string type = Console.ReadLine();

            Print(startOf, endOf, type);
            
        }

        static void Print(int start, int end, string type)
        {
            int startOf = start;
            int endOf = end;

            Predicate<int> predicate = null;

            if (type == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else
            {
                predicate = x => x % 2 != 0;
            }

            for (int i = startOf; i <= endOf; i++)
            {
                bool isEvenOrOdd = predicate(i);
                if (isEvenOrOdd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
