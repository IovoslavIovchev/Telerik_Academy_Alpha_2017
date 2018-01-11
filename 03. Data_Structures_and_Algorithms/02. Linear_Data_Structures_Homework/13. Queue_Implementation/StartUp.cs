using System;
using System.Collections.Generic;

namespace Queue_Implementation
{
    class StartUp
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(8);
            Console.WriteLine(queue.Dequeue());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
        }
    }
}
