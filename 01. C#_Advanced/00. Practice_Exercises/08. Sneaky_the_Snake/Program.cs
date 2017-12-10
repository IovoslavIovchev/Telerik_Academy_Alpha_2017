using System;
using System.Linq;

namespace Sneaky_the_Snake
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static int L = 3;
        static void Main(string[] args)
        {
            char[,] den = InitializeMatrix();
            int r = den.GetLength(0), c = den.GetLength(1);

            FillMatrix(den, r, c);

            char[] directions = Console.ReadLine().Split(',').Select(char.Parse).ToArray();

            for (int i = 0; i < directions.Length; i++)
            {
                Move(directions[i]);

                if ((i + 1) % 5 == 0)
                    L--;

                if (L <= 0) //STARVES
                {
                    Console.WriteLine("Sneaky is going to starve at [{0},{1}]", x, y);
                    return;
                }

                if (x >= r) //LOST IN DEPTHS
                {
                    Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", L);
                    return;
                }

                if (y < 0) y = c - 1;
                if (y >= c) y = 0;

                switch (den[x, y])
                {
                    case '@':
                        L++; den[x, y] = '-';
                        break;
                    case '%': //HITS A ROCK
                        Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", x, y);
                        return;
                    case 'e':
                        Console.WriteLine("Sneaky is going to get out with length {0}", L);
                        return;
                    default: break;
                }
            }

            Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", x, y);
        }

        static char[,] InitializeMatrix()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return new char[dimensions[0], dimensions[1]];
        }

        static void FillMatrix(char[,] m, int r, int c)
        {
            for (int i = 0; i < r; i++)
            {
                string temp = Console.ReadLine();
                for (int j = 0; j < c; j++)
                {
                    m[i, j] = temp[j];
                    if (temp[j].Equals('e') && x == 0) y = j;
                }
            }
        }

        static void Move(char d)
        {
            switch (d)
            {
                case 'w': x--; break;
                case 'a': y--; break;
                case 's': x++; break;
                case 'd': y++; break;
                default: break;
            }
        }
    }
}
