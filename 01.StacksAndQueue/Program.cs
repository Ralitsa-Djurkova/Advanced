using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] numbers1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>(numbers1);

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (i == 0)
                {
                    nums.Push(currentNum);
                }
                else if (i == 1)
                {
                    nums.Pop();
                }
                else if (i == 2)
                {

                    if (nums.Contains(currentNum))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {

                        Console.WriteLine(nums.Min);

                    }
                    if (nums.Count == 0)
                    {
                        Console.WriteLine($"{0}");
                    }

                }
            }
        }
    }
}
