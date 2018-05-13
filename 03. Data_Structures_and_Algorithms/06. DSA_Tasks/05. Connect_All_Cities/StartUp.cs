using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect_All_Cities
{
    static class Console2
    {
        static int index = 0;

        static string[] stuff = @"3
2
01
10
5
01100
10100
11000
00001
00010
6
010000
101000
010100
001000
000001
000010".Split(Environment.NewLine);

        public static string ReadLine()
        {
            return stuff[index++];
        }
    }

    class StartUp
    {
        private static StringBuilder result;

        private static Dictionary<int, List<int>> connections;

        private static void GetCities()
        {
            int N = int.Parse(Console2.ReadLine());
            int edges = 0;

            connections = new Dictionary<int, List<int>>();

            for (int i = 0; i < N; i++)
            {
                connections.Add(i, new List<int>());
                int[] temp = Console2.ReadLine()
                    .ToCharArray()
                    .Select(x => int.Parse(x.ToString()))
                    .ToArray();

                for (int j = 0; j < N; j++)
                {
                    if (temp[j] == 1)
                    {
                        connections[i].Add(j);
                        edges++;
                    }
                }
            }

            if (N - 1 > edges / 2)
            {
                result.AppendLine("-1");
            }
            else
            {
                result.AppendLine("1");
                // some DFS
            }

            connections.Clear();
        }

        public static void Main()
        {
            result = new StringBuilder();
            int T = int.Parse(Console2.ReadLine());

            for (int i = 0; i < T; i++)
            {
                GetCities();
            }
        }
    }
}