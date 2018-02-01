using System;
using System.Linq;

namespace Largest_Area_in_Matrix
{
    class StartUp
    {
        static int R;
        static int C;
        static string[][] matrix;
        static int max;
        static int temp;

        static void Main()
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            R = size[0]; C = size[1];

            matrix = new string[R][];

            for (int i = 0; i < R; i++)
                matrix[i] = Console.ReadLine()
                    .Split();


            for (int r = 0; r < R; r++)
            {
                for (int c = 0; c < C; c++)
                {
                    if (!matrix[r][c].Equals("V"))
                    {
                        temp = 0;
                        DFS(r, c, matrix[r][c], matrix);
                    }
                }
            }

            Console.WriteLine(max);
        }

        static void DFS(int r, int c, string num, string[][] m)
        {
            if (r < 0 || r > R - 1 || c < 0 || c > C - 1)
                return;
            if (!m[r][c].Equals(num))
                return;
            if (m[r][c].Equals("V"))
                return;

            temp++;
            m[r][c] = "V";
            max = Math.Max(max, temp);

            DFS(r - 1, c, num, m);
            DFS(r + 1, c, num, m);
            DFS(r, c - 1, num, m);
            DFS(r, c + 1, num, m);
        }
    }
}