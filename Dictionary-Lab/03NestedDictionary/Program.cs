using System;
using System.Collections.Generic;
using System.Linq;

namespace _03NestedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>();

            while (command != "Revision")
            {
                string[] tokens = command.Split(", ");
                string shopName = tokens[0];
                string product = tokens[1];
                double productPrice = double.Parse(tokens[2]);

                if (!products.ContainsKey(shopName))
                {
                    products.Add(shopName, new Dictionary<string, double>());

                }
                products[shopName].Add(product, productPrice);
                command = Console.ReadLine();
            }
            var orderShop = products.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in orderShop)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var collect in item.Value)
                {
                    Console.WriteLine($"Product: {collect.Key}, Price: {collect.Value}");
                }

            }
        }
    }
}
