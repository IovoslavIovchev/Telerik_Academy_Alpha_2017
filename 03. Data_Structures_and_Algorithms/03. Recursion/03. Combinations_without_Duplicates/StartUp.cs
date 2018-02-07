using System;
using System.Collections.Generic;

namespace Combinations_without_Duplicates
{
    class StartUp
    {
        static int N;

        static int K;

        static int[] array;

        static List<string> result;

        static void Main()
        {
            N = int.Parse(Console.ReadLine());
            K = int.Parse(Console.ReadLine());

            array = new int[K];
            result = new List<string>();

            Recurse();

            Console.WriteLine(string.Join(", ", result));
        }

        static void Recurse(int iteration = 0)
        {
            if (iteration == K)
            {
                for (int i = K - 1; i > 0; i--)
                {
                    if (array[i] <= array[i - 1]) return;
                }

                result.Add($"({string.Join(" ", array)})");
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                array[iteration] = i;
                Recurse(iteration + 1);
            }
        }
    }
}
