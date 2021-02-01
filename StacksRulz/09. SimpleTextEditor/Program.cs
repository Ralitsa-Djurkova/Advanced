using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "1":
                        stack.Push(text);
                        text += command[1];
                        break;
                    case "2":
                        stack.Push(text);
                        text = text.Substring(0, text.Length - int.Parse(command[1]));
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case "4":
                       text =  stack.Pop();
                        break;
                   
                }
            }
        }   }  
}
