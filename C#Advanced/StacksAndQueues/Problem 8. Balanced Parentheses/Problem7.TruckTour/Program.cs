using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8.BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            string[] expression = Console.ReadLine()
                .Split();

            Stack<string> firstPartOfExpr = new Stack<string>();
            Queue<string> secoundPartOfExpr = new Queue<string>();
            bool isBalanced = true;

            for (int i = 0; i < expression.Length; i++)
            {
                if (i < expression.Length / 2)
                {
                    firstPartOfExpr.Push(expression[i]);
                }
                else
                {
                    secoundPartOfExpr.Enqueue(expression[i]);
                }
            }

            for (int i = 0; i < firstPartOfExpr.Count; i++)
            {
                if (firstPartOfExpr.Pop() == "(" && secoundPartOfExpr.Dequeue() !=")")
                {
                    isBalanced = false;
                    break;
                }
                else if (firstPartOfExpr.Pop() == "[" && secoundPartOfExpr.Dequeue() != "]")
                {
                    isBalanced = false;
                    break;
                }
                else if (firstPartOfExpr.Pop() == "{" && secoundPartOfExpr.Dequeue() != "}")
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }




        }
    }
}
