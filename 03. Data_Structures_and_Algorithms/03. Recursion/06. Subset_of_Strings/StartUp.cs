using System;
using System.Collections.Generic;

namespace Subset_of_Strings
{
    class StartUp
    {
        static string[] S;

        static int K;

        static string[] Subset;

        static List<string> result;

        static void Main()
        {
            S = Console.ReadLine().Split();
            K = int.Parse(Console.ReadLine());
            Subset = new string[K];
            result = new List<string>();

            Recurse();

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        static void Recurse(int iteration = 0)
        {
            if (iteration == K)
            {
                for (int i = Subset.Length - 1; i > 0; i--)
                {
                    if (Array.IndexOf(S, Subset[i]) <= Array.IndexOf(S, Subset[i - 1]) || Subset[i] == Subset[i - 1]) return;
                }

                result.Add($"({string.Join(" ", Subset)})");
                return;
            }

            for (int i = 0; i < S.Length; i++)
            {
                Subset[iteration] = S[i];
                Recurse(iteration + 1);
            }
        }
    }
}
