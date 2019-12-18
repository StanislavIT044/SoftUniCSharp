using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> chemicalLiquids = new Queue<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> physicalItems = new Stack<int>(
                Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Dictionary<string, int> AdvancedMaterials = new Dictionary<string, int>
            {
                { "Aluminium", 0},
                { "Carbon fiber", 0},
                { "Glass", 0},
                { "Lithium", 0}
            };

            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                int currentLiquid = chemicalLiquids.Dequeue();
                int currentItem = physicalItems.Pop();
                int currentResult = currentLiquid + currentItem;

                if (currentResult == 25)
                {
                    AdvancedMaterials["Glass"]++;
                }
                else if (currentResult == 50)
                {
                    AdvancedMaterials["Aluminium"]++;
                }
                else if (currentResult == 75)
                {
                    AdvancedMaterials["Lithium"]++;
                }
                else if (currentResult == 100)
                {
                    AdvancedMaterials["Carbon fiber"]++;
                }
                else
                {
                    physicalItems.Push(currentItem + 3);
                }
            }

            if (!AdvancedMaterials.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (chemicalLiquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }

            if (physicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }

            foreach (var item in AdvancedMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
