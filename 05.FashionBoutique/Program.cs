using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);

            int rackCounter = 0;
            int sum = 0;
            while (stack.Count > 0)
            {
                var number = stack.Peek();
                
                if(sum + number > capacity)
                {
                    rackCounter++;
                    sum = 0;
                }
                else if(sum + number == capacity)
                {
                    rackCounter++;
                    sum = 0;
                    stack.Pop();
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            if(sum > 0)
            {
                rackCounter++;
            }

            Console.WriteLine(rackCounter);
            
        }
    }
}
