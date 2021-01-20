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
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var students = Console.ReadLine().Split();
                var name = students[0];
                var grades = double .Parse(students[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                }

                studentsGrades[name].Add(grades);
            }

            foreach (var pair in studentsGrades)
            {
                var name = pair.Key;
                var grade = pair.Value;
                var average = grade.Average();

                Console.Write($"{name} -> ");

                foreach (var grades in grade)
                {
                    Console.Write($"{grades:f2} ");
                    Console.WriteLine($"(avg: {average:f2})");
                }
            }
        }
    }
}
