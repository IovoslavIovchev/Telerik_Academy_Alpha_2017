using System;
using System.Linq;

namespace Coki_Skoki
{
    class StartUp
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] buildings = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] jumps = new int[N];

            for (int i = N - 2; i >= 0; i--)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (buildings[j] > buildings[i])
                    {
                        jumps[i] = jumps[j] + 1;
                        break;
                    }
                }
            }

            Console.WriteLine(jumps.Max());
            Console.WriteLine(string.Join(" ", jumps));
        }
    }
}