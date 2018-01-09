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
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] result = new int[N];

            for (int i = 0; i < N - 1; i++)
            {
                
            }

            Console.WriteLine(result.Max());
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
