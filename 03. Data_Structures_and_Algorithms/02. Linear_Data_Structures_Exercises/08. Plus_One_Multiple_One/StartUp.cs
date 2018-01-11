using System;
using System.Collections.Generic;
using System.Linq;

namespace Plus_One_Multiple_One
{
    class StartUp
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            queue.Enqueue(array[0]);

            int N = queue.Dequeue();
            for (int i = 0; i < array[1]; i++)
            {
                queue.Enqueue(N + 1);
                queue.Enqueue(N * 2 + 1);
                queue.Enqueue(N + 2);
                N = queue.Dequeue();
            }

            Console.WriteLine(N);
        }
    }
}
