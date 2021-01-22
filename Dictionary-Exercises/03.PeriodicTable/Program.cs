using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(" ").ToArray();

                for (int j = 0; j < elements.Length; j++)
                {
                    string currElement = elements[j];
                    chemicalElements.Add(currElement);
                }

            }

            foreach (var item in chemicalElements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
