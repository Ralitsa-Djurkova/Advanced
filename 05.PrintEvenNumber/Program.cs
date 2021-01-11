using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
           

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    queue.Enqueue(currentNum);
                    queue.Dequeue();
                    
                }
                else
                {
                    queue.Dequeue();
                }


            }

            int[] arrya = queue.ToArray();
            Console.Write(String.Join(", ", arrya));



        }
    }
}
