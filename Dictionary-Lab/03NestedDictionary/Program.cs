﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03NestedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] splettet = input.Split();
                string shop = splettet[0];
                string product = splettet[1];
                double price = double.Parse(splettet[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, price);
                }
                 input = Console.ReadLine();
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key} Price: {product.Value}");
                }
            }
        }
    }
}
