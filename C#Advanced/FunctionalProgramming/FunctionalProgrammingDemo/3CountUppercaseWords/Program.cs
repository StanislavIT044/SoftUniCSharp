using System;
using System.Linq;

namespace _3CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            var words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }







        }
    }
}
