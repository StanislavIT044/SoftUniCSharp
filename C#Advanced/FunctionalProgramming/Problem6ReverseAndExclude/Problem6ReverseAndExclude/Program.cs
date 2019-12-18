using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int nToDivide = int.Parse(Console.ReadLine());

            Func<int, bool> isDivivisible = x => x % nToDivide != 0;

            var numToPrint = numbers.Where(isDivivisible).Reverse();

            Console.WriteLine(string.Join(" ", numToPrint));
        }
    }
}
