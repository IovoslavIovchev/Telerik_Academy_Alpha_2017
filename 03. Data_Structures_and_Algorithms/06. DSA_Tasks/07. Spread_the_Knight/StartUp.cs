using System;
using System.Collections.Generic;
using System.Text;

namespace Spread_the_Knight
{
    class StartUp
    {
        private static long[,] chessboard;

        private static bool[,] visited;

        private static int[] X = { -2, 2, -2, 2, -1, 1, -1, 1 };

        private static int[] Y = { -1, -1, 1, 1, -2, -2, 2, 2 };

        private static Queue<Data> q;

        private static void InitializeChessboard()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            chessboard = new long[N, M];
            visited = new bool[N, M];
            q = new Queue<Data>();
        }

        private static bool IsValid(int r, int c)
        {
            return r > -1 && c > -1 && r < chessboard.GetLength(0) && c < chessboard.GetLength(1) && !visited[r, c];
        }

        private static void BFS()
        {
            int R = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            q.Enqueue(new Data(R, C, 1));

            while (q.Count != 0)
            {
                Data temp = q.Dequeue();
                if (IsValid(temp.R, temp.C))
                {
                    if (temp.C == chessboard.GetLength(1) / 2)
                    chessboard[temp.R, temp.C] = temp.Value;
                    visited[temp.R, temp.C] = true;

                    for (int i = 0; i < 8; i++)
                    {
                        if (IsValid(temp.R + X[i], temp.C + Y[i]))
                        {
                            q.Enqueue(new Data(temp.R + X[i], temp.C + Y[i], temp.Value + 1));
                        }
                    }
                }
            }
        }

        private static void PrintResult()
        {
            int mid = chessboard.GetLength(1) / 2;
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                result.AppendLine(chessboard[i, mid].ToString());
            }

            Console.Write(result.ToString());
        }

        public static void Main()
        {
            InitializeChessboard();

            BFS();

            PrintResult();
        }
    }

    struct Data
    {
        public Data(int r, int c, int value)
        {
            R = r;
            C = c;
            Value = value;
        }

        public int R { get; set; }

        public int C { get; set; }

        public int Value { get; set; }
    }
}