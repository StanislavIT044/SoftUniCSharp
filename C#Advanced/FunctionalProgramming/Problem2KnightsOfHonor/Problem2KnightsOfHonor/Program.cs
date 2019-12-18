using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = names => 
            Console.WriteLine(string.Join(Environment.NewLine, names.Select(name => $"Sir {name}")));

            print(input);




        }
    }
}
