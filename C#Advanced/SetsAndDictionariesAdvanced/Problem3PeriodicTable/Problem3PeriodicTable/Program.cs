using System;
using System.Collections.Generic;

namespace Problem3PeriodicTable
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elementsToAdd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < elementsToAdd.Length; j++)
                {
                    elements.Add(elementsToAdd[j]);
                }
            }

            Console.WriteLine(string.Join(" ", elements));

        }
    }
}
