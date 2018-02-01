using System;
using System.Collections.Generic;
using System.Text;

namespace Dog_Loves_Paper
{
    class StartUp
    {
        static SortedDictionary<int, int> parents;

        static Dictionary<int, List<int>> children;

        static SortedDictionary<int, bool> visited;

        static StringBuilder result;

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            parents = new SortedDictionary<int, int>();
            children = new Dictionary<int, List<int>>();
            visited = new SortedDictionary<int, bool>();

            for (int i = 0; i < N; i++)
            {
                InitializeGraph();
            }

            GenerateNumber();

            Console.WriteLine(result);
        }

        private static void GenerateNumber()
        {
            result = new StringBuilder();
            bool resultIsEmpty = true;
            bool allDone = false;
            while (!allDone)
            {
                allDone = true;
                foreach (var item in parents.Keys)
                {
                    if (visited[item]) continue;

                    if ((resultIsEmpty && item == 0))
                    {
                        allDone = false;
                        continue;
                    }

                    if (parents[item] == 0)
                    {
                        result.Append(item);
                        resultIsEmpty = false;
                        allDone = false;
                        visited[item] = true;

                        foreach (var child in children[item])
                        {
                            parents[child]--;
                        }
                        break;
                    }
                }
            }
            
        }

        private static void InitializeGraph()
        {
            string[] args = Console.ReadLine().Split();
            int child = -1, parent = 0;

            switch (args[2])
            {
                case "before":
                    parent = int.Parse(args[0]);
                    child = int.Parse(args[3]);
                    break;
                case "after":
                    child = int.Parse(args[0]);
                    parent = int.Parse(args[3]);
                    break;
            }

            if (!parents.ContainsKey(child) && !visited.ContainsKey(child))
            {
                parents.Add(child, 0);
                visited.Add(child, false);
            }
            if (!parents.ContainsKey(parent) && !visited.ContainsKey(parent))
            {
                parents.Add(parent, 0);
                visited.Add(parent, false);
            }

            parents[child]++;
            if (!children.ContainsKey(parent))
            {
                children.Add(parent, new List<int>());
            }
            if (!children.ContainsKey(child))
            {
                children.Add(child, new List<int>());
            }
            children[parent].Add(child);
        }
    }
}
