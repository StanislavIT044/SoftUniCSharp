using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem12TriFunction
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int, bool> traversFunc = (str, sum) =>
            {
                int sumOfChars = 0;
                foreach (char ch in str)
                {
                    sumOfChars += (int)ch;
                }
                if (sumOfChars >= n)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            };

            string strToPrint = string.Empty;

            foreach (var name in names)
            {
                if (traversFunc(name, n))
                {
                    strToPrint = name;
                    break;
                }
            }

            Console.WriteLine(strToPrint);
        }
    }
}
