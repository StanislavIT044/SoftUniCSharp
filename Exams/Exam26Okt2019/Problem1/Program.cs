using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] males = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] females = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> malesStack = new Stack<int>(males);
            Queue<int> femalesQueue = new Queue<int>(females);

            int matches = 0;

            while (malesStack.Count > 0 && femalesQueue.Count > 0)
            {
                int male = malesStack.Peek();
                int female = femalesQueue.Peek();

                if (male <= 0)
                {
                    if (malesStack.Count - 2 >= 0)
                    {
                        male = malesStack.Pop();
                    }
                }
                if (female <= 0)
                {
                    if (femalesQueue.Count - 2 >= 0)
                    {
                        female = femalesQueue.Dequeue();
                    }
                }
                else
                {
                    if (male % 25 == 0 && malesStack.Count - 3 >= 0)
                    {
                        male = malesStack.Pop();
                        male = malesStack.Pop();

                    }
                    else if (female % 25 == 0 && femalesQueue.Count - 3 >= 0)
                    {
                        female = femalesQueue.Dequeue();
                        female = femalesQueue.Dequeue();
                    }

                    if (male == female)
                    {
                        matches++;
                        malesStack.Pop();
                        femalesQueue.Dequeue()
                    }
                    else
                    {
                        male = malesStack.Pop();
                        male -= 2;
                        malesStack.Push(male);
                    }
                }


            }

            Console.WriteLine($"Matches: {matches}");

            if (malesStack.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", malesStack)}");
            }

            if (femalesQueue.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", femalesQueue)}");
            }
        }
    }
}
