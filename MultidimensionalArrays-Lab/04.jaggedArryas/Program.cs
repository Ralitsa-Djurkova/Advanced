using System;

namespace _04.jaggedArryas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArrya = new int[3][];

            jaggedArrya[0] = new int[2];
            jaggedArrya[1] = new int[1];
            jaggedArrya[2] = new int[3];

            for (int row = 0; row < jaggedArrya.Length; row++)// read jaggedArrya from the console
            {
                for (int col = 0; col < jaggedArrya[row].Length; col++)
                {
                    jaggedArrya[row][col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < jaggedArrya.Length; row++)// print jaggedArrya from the console
            {
                for (int col = 0; col < jaggedArrya[row].Length; col++)
                {
                    Console.Write(jaggedArrya[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
