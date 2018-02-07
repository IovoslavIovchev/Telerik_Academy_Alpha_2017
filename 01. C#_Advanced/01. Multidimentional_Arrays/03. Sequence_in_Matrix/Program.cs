using System;
using System.Linq;

namespace Sequence_in_Matrix
{
    class Program
    {
        static int max = 1;

        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int N = size[0], M = size[1];

            int[,] m = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < M; j++)
                    m[i, j] = temp[j];
            }

            Horizontal(m, N, M);
            Vertical(m, N, M);
            DiagonalRight(m, N, M);
            DiagonalLeft(m, N, M);

            Console.WriteLine(max);
        }

        static void Vertical(int[,] m, int N, int M)
        {
            for (int i = 0; i < N; i++)
            {
                int temp = 1;
                for (int j = 0; j < M - 1; j++)
                {
                    if (m[i, j] == m[i, j + 1])
                        temp++;
                    else
                    {
                        max = Math.Max(max, temp);
                        temp = 1;
                    }
                }
            }
        }

        static void Horizontal(int[,] m, int N, int M)
        {
            for (int j = 0; j < M; j++)
            {
                int temp = 1;
                for (int i = 0; i < N - 1; i++)
                {
                    if (m[i, j] == m[i + 1, j])
                        temp++;
                    else
                        temp = 1;

                    max = Math.Max(max, temp);
                }
            }
        }

        static void DiagonalRight(int[,] m, int N, int M)
        {
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < M - 1; j++)
                {
                    int temp = 1;
                    for (int r = i, c = j; r < N - 1 && c < M - 1; r++, c++)
                    {
                        if (m[r, c] == m[r + 1, c + 1])
                            temp++;
                        else
                            temp = 1;

                        max = Math.Max(max, temp);
                    }
                }
            }
        }

        static void DiagonalLeft(int[,] m, int N, int M)
        {
            for (int i = 0; i < N - 1; i++)
            {
                int temp = 1;
                for (int j = M - 1; j >= 1; j--)
                {
                    for (int r = i, c = j; r < N - 1 && c > 0; r++, c--)
                    {
                        if (m[r, c] == m[r + 1, c - 1])
                            temp++;
                        else
                            temp = 1;

                        max = Math.Max(max, temp);
                    }
                }
            }
        }
    }
}
