using System;
using System.Collections.Generic;

namespace _04.StackMatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expretion = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expretion.Length; i++)
            {
                if(expretion[i] == '(')
                {
                    stack.Push(i);
                }

                if(expretion[i] == ')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(expretion.Substring(start, i - start + 1));
                }
            }
        }
    }
}
