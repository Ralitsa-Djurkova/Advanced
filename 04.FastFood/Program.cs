using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodPerDay = int.Parse(Console.ReadLine());
            int[] clientsOrder = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> clients = new Queue<int>(clientsOrder);
            Console.WriteLine(clients.Max());

            for (int i = 0; i < clientsOrder.Length; i++)
            {
                var food = clients.Peek();
                if (foodPerDay >= food)
                {
                    foodPerDay -= food;
                    clients.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (clients.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ", clients));
            }
        }
    }
}
