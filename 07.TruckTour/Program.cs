using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsOfPomps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < numsOfPomps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }
            int totalfuel = 0;
            for (int i = 0; i < numsOfPomps; i++)
            {
                string currentInfo = queue.Dequeue();
                var info = currentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalfuel += fuel;

                if(totalfuel >= distance)
                {
                    totalfuel -= distance;
                }
                else
                {
                    totalfuel = 0;
                    i = -1;
                }

                queue.Enqueue(currentInfo);
            }
            var firstElement = queue.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}
