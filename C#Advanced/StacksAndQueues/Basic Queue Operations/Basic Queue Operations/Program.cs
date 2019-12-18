using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            int[] NSX = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numForQueue = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> Queue = new Queue<int>(NSX[0]);            

            for (int i = 0; i < NSX[0]; i++)
            {
                Queue.Enqueue(numForQueue[i]);
            }

            for (int i = 0; i < NSX[1]; i++)
            {
                Queue.Dequeue();
            }

            if (Queue.Contains(NSX[2]))
            {
                Console.WriteLine("true");
            }
            else if (Queue.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Queue.Min());
            }








        }
    }
}
