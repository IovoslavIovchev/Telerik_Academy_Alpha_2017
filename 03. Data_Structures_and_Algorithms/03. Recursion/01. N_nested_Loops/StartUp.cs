using System;
using System.Collections.Generic;

namespace N_nested_Loops
{
    class StartUp
    {
        static int N;

        static int[] loop;

        static List<string> loops;

        static void Main()
        {
            N = int.Parse(Console.ReadLine());

            loop = new int[N];

            loops = new List<string>();

            Loop(0);

            Console.WriteLine(string.Join(Environment.NewLine, loops));
        }

        static void Loop(int currentIteration)
        {
            if (currentIteration == N)
            {
                loops.Add(string.Join(" ", loop));
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                loop[currentIteration] = i;
                Loop(currentIteration + 1);
            }
        }
    }
}
