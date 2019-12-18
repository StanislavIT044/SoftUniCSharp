using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem9ListОfPredicates
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> divideFunc = (x, y) => x % y != 0;
            List<int> listToPrint = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isDivideByAll = true;

                foreach (var num in numbers)
                {
                    //divideFunc = x => x % num != 0;
                    if (divideFunc(i, num))
                    {
                        isDivideByAll = false;
                        break;
                    }
                }
                if (isDivideByAll)
                {
                    listToPrint.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", listToPrint));
        }
    }
}
