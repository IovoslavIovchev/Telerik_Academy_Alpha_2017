using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    class StartUp
    {
        static int[] parents;

        static List<int>[] children;

        static bool[] visited;

        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int N = input[0], M = input[1];

            InitializeDependencies(N, M);

            bool allAreVisited = false;

            while (!allAreVisited)
            {
                allAreVisited = true;
                for (int i = 0; i < N; i++)
                {
                    if (parents[i] == 0 && !visited[i])
                    {
                        allAreVisited = false;
                        Console.WriteLine(i);
                        visited[i] = true;

                        if (children[i] == null) continue;

                        foreach (var child in children[i])
                        {
                            parents[child]--;
                        }
                        break;
                    }
                }

            }
        }

        private static void InitializeDependencies(int N, int M)
        {
            parents = new int[N];
            children = new List<int>[N];
            visited = new bool[N];

            for (int i = 0; i < M; i++)
            {
                int[] temp = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                int parent = temp[0], child = temp[1];

                parents[child]++;
                if (children[parent] == null) children[parent] = new List<int>();
                children[parent].Add(child);
            }
        }
    }
}