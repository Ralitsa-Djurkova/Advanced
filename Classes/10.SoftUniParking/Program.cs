using System;

namespace _10.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int rows = 0;
            int cols = 0;

            char[][] field = new char[size][];
            // матрицата е напълнена
            for (int r = 0; r < size; r++)
            {
                field[r] = new char[size];
                char[] col = Console.ReadLine().ToCharArray();

                for (int c = 0; c < size; c++)
                {
                    char ch = col[c];

                    if(ch == 'S')
                    {
                        rows = r;
                        cols = c;
                    }

                    field[r][c] = ch;
                }
            }
            int price = 0;
            while (true)
            {
                string command = Console.ReadLine();
                field[rows][cols] = '-';
                // up = row - 1, col
                //down = row + 1, col
                //right = row, col +1;
                //left = row, col - 1;

                bool isOutOfField = false;
                switch (command)
                {
                    case "up":
                        rows -= 1;
                        break;
                    case "down":
                        rows += 1;
                        break;
                    case "left":
                        cols -= 1;
                        break;
                    case "right":
                        cols += 1; // out of matrix

                        break;

                }
                 
                if (IsOutsize(size, rows, cols))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                char element = field[rows][cols];

                if(element == 'O')
                {
                    field[rows][cols] = '-';

                    for (int r = 0; r < size; r++)
                    {
                        bool found = false;
                        for (int c = 0; c < size; c++)
                        {
                            char currMatrixElement = field[r][c];
                            if(currMatrixElement == 'O')
                            {
                                rows = r;
                                cols = c;

                               
                                found = true;
                                break;
                            }
                           
                        }

                        if (found)
                        {
                            break;
                        }
                    }
                }
                else if (char.IsDigit(element))
                {
                    price += element - '0';

                }

                field[rows][cols] = 'S';

                if (price >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    break;
                }

               
            }

            Console.WriteLine($"Money: {price}");
            foreach (char[] col in field)
            {
                Console.WriteLine(string.Join("", col));
            }
        }

        private static bool IsOutsize(int size, int rows, int cols)
        {
            return rows >= size ||
                rows < 0 ||
                cols >= size ||
                cols < 0;
        }
    }
}
