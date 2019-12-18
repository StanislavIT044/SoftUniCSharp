using System;
using System.Linq;

namespace _4AddVAT
{
    class Program
    {
        static void Main()
        {
            double[] price = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var item in price)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
