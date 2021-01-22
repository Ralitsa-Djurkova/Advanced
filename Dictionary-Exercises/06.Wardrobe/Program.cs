using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wordrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ").ToArray();
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",").ToArray();

                if (!wordrobe.ContainsKey(color))
                {
                    wordrobe.Add(color, new Dictionary<string, int>());
                }
                Dictionary<string, int> curruntColorClothing = wordrobe[color];

                foreach (string item in clothes)
                {
                    if (!curruntColorClothing.ContainsKey(item))
                    {
                        curruntColorClothing.Add(item, 0);
                    }
                    curruntColorClothing[item]++;
                }

            }
            string[] searchData = Console.ReadLine().Split(" ");
            foreach ((string color, Dictionary<string, int> colorData) in wordrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach ((string clothes, int count) in colorData)
                {
                    if (searchData[0] == color && searchData[1] == clothes)
                    {
                        Console.WriteLine($"* {clothes} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes} - {count}");
                    }
                }

            }
        }
    }
}
