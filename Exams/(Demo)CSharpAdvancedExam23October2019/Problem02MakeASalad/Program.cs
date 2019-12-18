using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vegetables = Console.ReadLine()
                .Split();
            int[] calories = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<string> queueOfVegetables = new Queue<string>(vegetables);
            Stack<int> stackOfCalories = new Stack<int>(calories);

            Dictionary<string, int> caloriesOfVegetables = new Dictionary<string, int>
            {
                { "tomato", 80},
                { "carrot", 136},
                { "lettuce", 109},
                { "potato", 215}
            };

            List<int> readySalads = new List<int>();

            while (queueOfVegetables.Count > 0 && stackOfCalories.Count > 0)
            {
                string currentVegetable = string.Empty;
                int currentCalories = stackOfCalories.Pop();

                int salad = currentCalories;
                readySalads.Add(salad);

                while (vegetables.Length > 0 && queueOfVegetables.Count > 0)
                {
                    currentVegetable = queueOfVegetables.Dequeue();

                    if (currentVegetable == "tomato")
                    {
                        currentCalories -= caloriesOfVegetables["tomato"];
                    }
                    else if (currentVegetable == "carrot")
                    {
                        currentCalories -= caloriesOfVegetables["carrot"];
                    }
                    else if (currentVegetable == "lettuce")
                    {
                        currentCalories -= caloriesOfVegetables["lettuce"];
                    }
                    else if (currentVegetable == "potato")
                    {
                        currentCalories -= caloriesOfVegetables["potato"];
                    }

                    if (!(currentCalories > 0))
                    {
                        break;
                    }
                }

                if (currentCalories > 0 && queueOfVegetables.Count <= 0)
                {
                    readySalads.Remove(salad);
                    break;
                }
            }


            Console.WriteLine(string.Join(" ", readySalads));

            if (stackOfCalories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", stackOfCalories));
            }
            else if (vegetables.Length > 0)
            {
                Console.WriteLine(string.Join(" ", queueOfVegetables));
            }

        }
    }
}
