using System;
using System.Linq;

namespace FunctionalProgrammingDemo
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(", ")
                .Select(MyParse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }

        static int MyParse(string n)
        {
            int number = int.Parse(n);
            return number;
        }
    }
}
