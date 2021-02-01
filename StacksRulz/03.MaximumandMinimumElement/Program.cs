using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumandMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int first = queries[0];

                if (first == 1)
                {
                    int second = queries[1];
                    stack.Push(second);
                }
                else if (first == 2)
                {
                    if (stack.Count > 0)
                    {
                        int maxNum = stack.Max();
                        stack.Pop();

                    }
                }
                else if (first == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());

                    }
                }
                else if (first == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());

                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
