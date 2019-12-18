using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split();

            Func<string, bool> filter = n => n.Length <= length;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(filter)));
        }
    }
}
