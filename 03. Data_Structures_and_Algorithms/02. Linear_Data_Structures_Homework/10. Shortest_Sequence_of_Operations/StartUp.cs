using System;
using System.Collections.Generic;
using System.Linq;

namespace Shortest_Sequence_of_Operations
{
    class StartUp
    {
        static List<long> count = new List<long>();

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            Try(N, M);
            
            long shortestSequence = count.Min();
            
            Console.WriteLine(shortestSequence);
        }

        static void Try(int N, int M, long c = 0)
        {
            if (N == M) count.Add(c);
            if (N > M) return;

            Try(N + 1, M, c + 1);
            Try(N + 2, M, c + 1);
            Try(N * 2, M, c + 1);
        }
    }
}
