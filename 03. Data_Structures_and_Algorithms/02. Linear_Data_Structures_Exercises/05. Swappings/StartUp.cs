using System;
using System.Collections.Generic;
using System.Linq;

namespace Swappings
{
    class StartUp
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 1; i <= N; i++)
            {
                list.AddLast(i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                list.AddFirst(nums[i]);
                while (list.Last.Value != nums[i])
                {
                    list.AddFirst(list.Last.Value);
                    list.RemoveLast();
                }
                list.RemoveLast();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }

    class Node
    {

    }
}