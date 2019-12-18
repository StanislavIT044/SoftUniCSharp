using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] numForStack = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers[0]);

            for (int i = 0; i < numForStack.Count(); i++)
            {
                stack.Push(numForStack[i]);
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numbers[2]))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            } 
            else 
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
