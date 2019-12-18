using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            int[] cloathesInTheBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacityOfARack = int.Parse(Console.ReadLine());

            int rack = 0;

            Stack<int> stackOfClothes = new Stack<int>();

            for (int i = 0; i < cloathesInTheBox.Length; i++)
            {
                stackOfClothes.Push(cloathesInTheBox[i]);
            }

            int capacyti = 0;

            while (stackOfClothes.Count > 0)
            {
                if (capacyti + stackOfClothes.Peek() <= capacityOfARack)
                {
                    capacyti += stackOfClothes.Pop();
                }
                else
                {
                    rack++;
                    capacyti = 0;
                }

            }

            Console.WriteLine(rack+1);

        }
    }
}
