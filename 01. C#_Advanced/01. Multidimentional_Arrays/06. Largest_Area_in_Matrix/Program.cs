using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_Area_in_Matrix
{
    class Program
    {
        static int r;
        static int c;
        static int[][] matrix;
        static bool[,] visited;
        static int max;
        static int temp;

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            r = size[0]; c = size[1];

            matrix = new int[r][];
            visited = new bool[r, c];

            for (int i = 0; i < r; i++)
                matrix[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();


            for (int i = 0; i < r; i++) //i for rows
            {
                for (int j = 0; j < c; j++) //j for cols
                {
                    if (!visited[i, j])
                    {
                        temp = 0;
                        DFS(i, j, matrix[i][j], matrix);
                    }
                }
            }

            Console.WriteLine(max);
        }

        static void DFS(int i, int j, int num, int[][] m)
        {
            if (i < 0 || i > r - 1 || j < 0 || j > c - 1)
                return;
            if (m[i][j] != num)
                return;
            if (visited[i, j])
                return;

            temp++;
            visited[i, j] = true;
            max = Math.Max(max, temp);

            DFS(i - 1, j, num, m);
            DFS(i + 1, j, num, m);
            DFS(i, j - 1, num, m);
            DFS(i, j + 1, num, m);
        }
    }
}
