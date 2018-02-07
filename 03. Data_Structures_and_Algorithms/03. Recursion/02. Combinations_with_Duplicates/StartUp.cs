using System;
using System.Collections.Generic;

namespace Combinations_with_Duplicates
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
