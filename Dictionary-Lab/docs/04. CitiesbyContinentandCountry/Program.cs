using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._CitiesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split(" ").ToArray();
                string continets = token[0];
                string countryies = token[1];
                string cities = token[2];

                if (!data.ContainsKey(continets))
                {
                    data[continets] = new Dictionary<string, List<string>>();
                }
                if (!data[continets].ContainsKey(countryies))
                {
                    data[continets][countryies] = new List<string>();
                }
                data[continets][countryies].Add(cities);
            }

            foreach (var continetCountry in data)
            {
                var continetName = continetCountry.Key;
                Console.WriteLine($"{continetName}: ");

                foreach (var countryCityt in continetCountry.Value)
                {
                    var countyName = countryCityt.Key;
                    var city = countryCityt.Value;
                    Console.Write($"{countyName} -> ");
                    Console.WriteLine(string.Join(", ",city));
                }
            }
        }
    }
}
