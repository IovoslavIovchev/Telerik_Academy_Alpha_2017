using System;
using System.Linq;

namespace Sneaky_the_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //70 out of 100
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { 'x' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int r = dimensions[0], c = dimensions[1];
            char[,] den = new char[r, c];

            long length = 3; bool inside = true; int x = 0, y = 0; //coordinates - x & y

            for (int i = 0; i < r; i++)
            {
                string temp = Console.ReadLine();
                for (int j = 0; j < temp.Length; j++)
                {
                    den[i, j] = temp[j];                
                    if (temp[j].Equals('e')) y = j;
                }
            }

            char[] directions = Console.ReadLine().Split(',').Select(char.Parse).ToArray();

            for (int i = 0; i < directions.Length; i++)
            {
                if ((i+1) % 5 == 0)
                {
                    length--;
                    if (length <= 0)
                    {
                        Console.WriteLine("Sneaky is going to starve at [{0},{1}]", x, y);
                        return;
                    }
                }

                switch (directions[i])
                {
                    case 'w': x--;
                        break;
                    case 'a': y--;
                        break;
                    case 's': x++;
                        break;
                    case 'd': y++;
                        break;
                }

                if (y < 0) y = (c + y) % c;
                if (y >= c) y = y % c;     
                if (x >= r)
                {
                    Console.WriteLine("Sneaky is going to be lost into the depths with length {0}", length);
                    return;
                }           
                
                switch (den[x, y])
                {
                    case '@': length++; den[x,y] = '-'; break;
                    case '%': Console.WriteLine("Sneaky is going to hit a rock at [{0},{1}]", x, y); return;
                    case 'e': inside = !inside; break;
                }
            }

            if (inside)
            {
                Console.WriteLine("Sneaky is going to be stuck in the den at [{0},{1}]", x, y);
                return;
            }

            Console.WriteLine("Sneaky is going to get out with length {0}", length);
        }
    }
}
