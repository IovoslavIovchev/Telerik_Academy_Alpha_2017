using System;

namespace Fill_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());

            int[][] matrix = new int[N][];
            for (int i = 0; i < N; i++) matrix[i] = new int[N];

            switch (Char.ToLower(ch))
            {
                case 'a': A(matrix, ref N); break;
                case 'b': B(matrix, ref N); break;
                case 'c': C(matrix, ref N); break;
                case 'd': D(matrix, ref N); break;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        static void A(int[][] m, ref int N)
        {
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    m[i][j] = N * j + i + 1;
                }
            }
        }

        static void B(int[][] m, ref int N)
        {
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            m[i][j] = j * N + i + 1;
                        else
                            m[i][j] = j * N + N - i;
                    }
                    else
                    {
                        if (j % 2 == 0)
                            m[i][j] = j * N + i + 1;
                        else
                            m[i][j] = j * N + N - i;
                    }
                }
            }
        }

        static void C(int[][] m, ref int N)
        {
            int c = 1;

            for (int i = (N - 1); i >= 0; i--)
            {
                int x = i, y = 0;
                while (x < N)
                {
                    m[x][y] = c++;
                    x++; y++;
                }
            }
            for (int i = 1; i < N; i++)
            {
                int x = 0, y = i;
                while (y < N)
                {
                    m[x][y] = c++;
                    x++; y++;
                }
            }
        }

        static void D(int[][] m, ref int N)
        {
            int x = 0, y = 0;
            int c = 1;
            char dir = 's';

            for (int i = 0; i < (N * N); i++)
            {
                if (dir.Equals('s') && (x >= N || m[x][y] != 0))
                {
                    x--; y++;
                    dir = 'd';
                }
                else if (dir.Equals('d') && (y >= N || m[x][y] != 0))
                {
                    y--; x--;
                    dir = 'w';
                }
                else if (dir.Equals('w') && (x < 0 || m[x][y] != 0))
                {
                    y--; x++;
                    dir = 'a';
                }
                else if (dir.Equals('a') && (y < 0 || m[x][y] != 0))
                {
                    y++; x++;
                    dir = 's';
                }

                m[x][y] = c++;

                switch (dir)
                {
                    case 's': x++; break;
                    case 'd': y++; break;
                    case 'w': x--; break;
                    case 'a': y--; break;
                }
            }
        }
    }
}
