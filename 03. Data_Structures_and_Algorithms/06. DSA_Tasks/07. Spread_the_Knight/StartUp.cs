using System;
using System.Collections.Generic;
using System.Text;

namespace Spread_the_Knight
{
    class Konsole
    {
        private static string[] arr = @"6
7
3
4".Split("\n");
        private static int i = 0;

        public static string ReadLine(){
            return arr[i++];
        }

        public static void Write(string str)
        {
            Console.Write(str);
        }
    }
    class StartUp
    {
        private static int C;

        private static long [, ] chessboard;

        private static Queue<int []> q;

        private static void InitializeChessboard()
        {
            int N = int.Parse(Konsole.ReadLine());
            int M = int.Parse(Konsole.ReadLine());

            chessboard = new long [N, M];
            q = new Queue<int []>();
            C = 0;
        }

        private static bool IsValid(int r, int c)
        {
            return r > -1 && c > -1 && r < chessboard.GetLength(0) && c < chessboard.GetLength(1) && chessboard [r, c] == 0;
        }

        private static void BFS()
        {
            int r = int.Parse(Konsole.ReadLine());
            int c = int.Parse(Konsole.ReadLine());

            q.Enqueue(new int [] { r, c, 1 });

            while (q.Count != 0)
            {
                int [] temp = q.Dequeue();
                if (IsValid(temp [0], temp [1]))
                {
                    chessboard [temp [0], temp [1]] = temp [2];

                    if (temp [1] == chessboard.GetLength(1) / 2)
                    {
                        C++;

                        if (C == chessboard.GetLength(0))
                        {
                            return;
                        }
                    }

                    if (IsValid(temp [0] - 2, temp [1] - 1))
                        q.Enqueue(new int [] { temp [0] - 2, temp [1] - 1, temp [2] + 1 });
                    if (IsValid(temp [0] + 2, temp [1] - 1))
                        q.Enqueue(new int [] { temp [0] + 2, temp [1] - 1, temp [2] + 1 });
                    if (IsValid(temp [0] - 2, temp [1] + 1))
                        q.Enqueue(new int [] { temp [0] - 2, temp [1] + 1, temp [2] + 1 });
                    if (IsValid(temp [0] + 2, temp [1] + 1))
                        q.Enqueue(new int [] { temp [0] + 2, temp [1] + 1, temp [2] + 1 });
                    if (IsValid(temp [0] - 1, temp [1] - 2))
                        q.Enqueue(new int [] { temp [0] - 1, temp [1] - 2, temp [2] + 1 });
                    if (IsValid(temp [0] + 1, temp [1] - 2))
                        q.Enqueue(new int [] { temp [0] + 1, temp [1] - 2, temp [2] + 1 });
                    if (IsValid(temp [0] - 1, temp [1] + 2))
                        q.Enqueue(new int [] { temp [0] - 1, temp [1] + 2, temp [2] + 1 });
                    if (IsValid(temp [0] + 1, temp [1] + 2))
                        q.Enqueue(new int [] { temp [0] + 1, temp [1] + 2, temp [2] + 1 });
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

            Konsole.Write(result.ToString());
        }

        public static void Main()
        {
            InitializeChessboard();

            BFS();

            PrintResult();
        }
    }
}