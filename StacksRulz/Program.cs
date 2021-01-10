using System;
using System.Collections.Generic;

namespace StacksRulz
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string book = Console.ReadLine();

            while (book != "end")
            {
                stack.Push(book);
                book = Console.ReadLine();
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
