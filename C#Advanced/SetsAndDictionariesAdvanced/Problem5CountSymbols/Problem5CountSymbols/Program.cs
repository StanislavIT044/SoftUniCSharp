using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem5CountSymbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            char[] array = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i];
            }

            Dictionary<char, int> charCounter = new Dictionary<char, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!charCounter.ContainsKey(array[i]))
                {
                    charCounter[array[i]] = 1;
                }
                else
                {
                    charCounter[array[i]]++;
                }
            }

            foreach (var key in charCounter.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key.Key}: {key.Value} time/s");
            }


        }
    }
}
