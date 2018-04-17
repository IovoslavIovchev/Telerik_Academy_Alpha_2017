using System;
using System.Collections.Generic;
using System.Linq;

namespace Girls_Gone_Wild
{
    class StartUp
    {
        private static int K;

        private static char[] L;

        private static string[] N;

        private static Dictionary<char, int> letterCount;

        private static List<string> result;

        private static void Initialize()
        {
            letterCount = new Dictionary<char, int>();
            result = new List<string>();

            K = int.Parse(Console.ReadLine());
            L = Console.ReadLine().ToCharArray().OrderBy(x => x).ToArray();

            foreach (var x in L)
            {
                if (!letterCount.ContainsKey(x))
                    letterCount.Add(x, 0);
                letterCount[x]++;
            }

            N = new string[int.Parse(Console.ReadLine())];
        }

        public static void Main()
        {
            Initialize();

            Recurse();

            Console.WriteLine(result.Count());
            Console.WriteLine(string.Join("\n", result));
        }

        private static void Recurse(int k = 0, int count = 0)
        {
            if (count == N.Length)
            {
                string toAdd = string.Join("-", N);
                if (!result.Contains(toAdd))
                {
                    result.Add(toAdd);
                }
                return;
            }

            for (int i = k; i < K; i++)
            {
                for (int j = 0; j < L.Length; j++)
                {
                    if (letterCount[L[j]] == 0) continue;

                    string current = $"{i}{L[j]}";
                    N[count] = current;
                    letterCount[L[j]]--;
                    Recurse(i + 1, count + 1);
                    letterCount[L[j]]++;
                }
            }
        }
    }
}