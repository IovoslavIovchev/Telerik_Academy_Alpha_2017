using System;
using System.Collections.Generic;
using System.Linq;

namespace Bishop_Path_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int x = size[0], y = size[1];

            int[,] matrix = new int[x,y];

            for (int i = x - 1; i >= 0; i--)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = 3 * (x + j - i - 1);
                }
            }

            long sum = 0;
            int p = x - 1, q = 0;
            short[,] coord = new short[1000, 750];

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] cmd = Console.ReadLine().ToUpper().Split(' ');    
                int step = int.Parse(cmd[1]);                

                for (int t = 1; t < step; t++)
                {  
                    switch (cmd[0])
                    {
                        case "RU": case "UR": if (p-1 >= 0 && q+1 < y) { p--; q++; }
                            break;
                        case "LU": case "UL": if (p-1 >= 0 && q-1 >= 0) { p--; q--; }
                            break;
                        case "DL": case "LD": if (p+1 < x && q-1 >= 0) { p++; q--; }
                            break;
                        case "DR": case "RD": if (p+1 < x && q+1 < y) { p++; q++; }
                            break;
                    }
                    
                    if (coord[p, q] == 0)
                    {
                        sum += matrix[p, q];
                        coord[p, q] = 1;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
