using System;
using System.Linq;

namespace Problem3CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> printMinNum = x => x.Min();

            Console.WriteLine(printMinNum(numbers));



        }
    }
}
