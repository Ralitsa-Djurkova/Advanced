using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers1);

            int s = numbers[1];
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            int x = numbers[2];

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            if(queue.Count == 0)
            {
                Console.WriteLine($"{0}");
            }
        }
    }
}
