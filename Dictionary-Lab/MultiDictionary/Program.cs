using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsInformation = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ").ToArray();
                string name = data[0];
                decimal grade = decimal.Parse(data[1]);

                if (!studentsInformation.ContainsKey(name))
                {
                    studentsInformation.Add(name, new List<decimal>());
                    studentsInformation[name].Add(grade);
                }
                else
                {
                    studentsInformation[name].Add(grade);
                }
            }


            foreach (var student in studentsInformation)
            {
                var name = student.Key;
                var studentgrades = student.Value;
                var avr = studentgrades.Average();
                Console.Write($"{name} -> ");

                foreach (var grade in studentgrades)
                {
                    Console.Write($"{grade:f2} ");

                }
                Console.WriteLine($"(avg: {avr:f2})");
            }
        }
    }
}
