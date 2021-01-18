using System;
using System.Linq;

namespace _08.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
           

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            char founSymbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i, j] == founSymbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        isFound = true;
                        return;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{founSymbol} does not occur in the matrix ");
            }

        }
    }
}
