using System;
using System.Collections.Generic;

namespace Problem6Wardrobe
{
    class Program
    {
        static void Main()
        {
            int countOfInputLines = int.Parse(Console.ReadLine());

            var wordrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < countOfInputLines; i++)
            {
                string[] colorAndClothes = Console.ReadLine().Split(" -> ");

                string colour = colorAndClothes[0];
                string[] clothes = colorAndClothes[1].Split(',');

                if (!wordrobe.ContainsKey(colour))
                {
                    wordrobe[colour] = new Dictionary<string, int>();
                }
                foreach (var piece in clothes)
                {
                    if (!wordrobe[colour].ContainsKey(piece))
                    {
                        wordrobe[colour].Add(piece, 0);
                    }
                    wordrobe[colour][piece]++;
                }
            }

            string[] clothingForSerch = Console.ReadLine().Split();

            foreach (var color in wordrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothing in color.Value)
                {
                    if (color.Key == clothingForSerch[0] && clothing.Key == clothingForSerch[1])
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }

                }

            }

        }
    }
}
