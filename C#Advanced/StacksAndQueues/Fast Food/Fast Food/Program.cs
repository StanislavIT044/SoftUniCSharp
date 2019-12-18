using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main()
        {
            int quantityOfTheFood = int.Parse(Console.ReadLine());
            int[] quantityOfTheOrders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>();

            for (int i = 0; i < quantityOfTheOrders.Length; i++)
            {
                orders.Enqueue(quantityOfTheOrders[i]);
            }

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (orders.Peek() <= quantityOfTheFood)
                {
                    quantityOfTheFood -= orders.Dequeue();
                    if (orders.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else
                {
                    Console.Write("Orders left: ");
                    while (orders.Count > 0)
                    {
                        if (orders.Count == 1)
                        {
                            Console.Write(orders.Dequeue());
                        }
                        else
                        {
                            Console.Write(orders.Dequeue() + " ");
                        }
                    }
                }
            }




        }
    }
}
