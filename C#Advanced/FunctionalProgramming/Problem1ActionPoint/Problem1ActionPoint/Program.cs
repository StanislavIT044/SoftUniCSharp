using System;
using System.Linq;

namespace Problem1ActionPoint
{
    class Program
    {
        static void Main()
        {
            Action<string> print = name => Console.WriteLine(name);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
        }
    }
}
