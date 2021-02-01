using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> costemer = new Queue<string>();

            int counter = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    string[] names = costemer.ToArray();
                    counter = costemer.Count;
                    if (counter > 0)
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            costemer.Dequeue();
                        }
                    }
                    Console.WriteLine(string.Join("\n", names));

                }
                else
                {
                    costemer.Enqueue(input);

                }
               
                input = Console.ReadLine();
            }
            counter = costemer.Count;
            Console.WriteLine($"{costemer.Count} people remaining.");

        }
    }
}
