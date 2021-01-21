using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            var counts = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 1;
                }
                else
                {
                    counts[num]++;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
