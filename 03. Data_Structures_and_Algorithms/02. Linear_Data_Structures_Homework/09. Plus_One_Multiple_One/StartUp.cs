using System;
using System.Collections.Generic;

namespace Plus_One_Multiple_One
{
    class StartUp
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();
            List<int> result = new List<int>();
            int N = int.Parse(Console.ReadLine());
            queue.Enqueue(N);

            N = queue.Dequeue();
            for (int i = 0; i < 50; i++)
            {
                queue.Enqueue(N + 1);
                queue.Enqueue(N * 2 + 1);
                queue.Enqueue(N + 2);
                N = queue.Dequeue();
                result.Add(N);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
