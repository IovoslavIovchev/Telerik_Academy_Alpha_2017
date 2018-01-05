using System;
using System.Collections.Generic;

namespace Delete_a_Node_in_Singly_LinkedList
{
    class StartUp
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 8, 34, 12, 8, 54, 3, 4, 98, 0, -4 };
            LinkedList<int> linkedList = new LinkedList<int>(list);

            Console.WriteLine(string.Join(", ", linkedList));

            int numToRemove = int.Parse(Console.ReadLine());

            DeleteNode(linkedList, numToRemove);

            Console.WriteLine(string.Join(", ", linkedList));
        }

        static void DeleteNode(LinkedList<int> linkedList, int numberToRemove)
        {
            var currentNode = linkedList.First;

            while (linkedList.Contains(numberToRemove))
            {
                linkedList.Remove(numberToRemove);
            }
        }
    }
}
