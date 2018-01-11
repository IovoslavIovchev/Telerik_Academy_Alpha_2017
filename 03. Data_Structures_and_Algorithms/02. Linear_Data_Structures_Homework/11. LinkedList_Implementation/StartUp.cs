using System;
using System.Collections.Generic;

namespace LinkedList_Implementation
{
    class StartUp
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(5);

            list.AddFirst(6);

            list.AddLast(4);

            Console.WriteLine(list.Last); //4

            Console.WriteLine(list.First.Next); //5

            Console.WriteLine(list.First); //6

            Console.WriteLine(list.First.Value + list.Last.Value); //10
        }
    }
}
