using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            HashSet<int> elements1 = new HashSet<int>();
            HashSet<int> elements2 = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                elements1.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                elements2.Add(num);
            }

            foreach (var item in elements1)
            {
                foreach (var item1 in elements2)
                {
                    if (item == item1)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
        }
    }
}
