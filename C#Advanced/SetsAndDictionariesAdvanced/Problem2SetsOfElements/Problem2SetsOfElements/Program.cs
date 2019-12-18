using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2SetsOfElements
{
    class Program
    {
        static void Main()
        {
            int[] NM = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < NM[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            HashSet<int> secoundSet = new HashSet<int>();

            for (int i = 0; i < NM[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secoundSet.Add(num);
            }

            List<int> numToPrint = new List<int>();

            foreach (var item in firstSet)
            {
                if (secoundSet.Contains(item))
                {
                    numToPrint.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", numToPrint));
        }
    }
}
