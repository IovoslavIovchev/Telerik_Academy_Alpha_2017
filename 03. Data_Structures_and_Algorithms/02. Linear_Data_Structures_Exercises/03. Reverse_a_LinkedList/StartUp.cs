using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Reverse_a_LinkedList
{
    class StartUp
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinkedList<int> linkedList = new LinkedList<int>(list);

            Console.Write("LinkedList: ");
            Console.WriteLine(string.Join(", ", linkedList));

            //   With a new LinkedList

            LinkedList<int> reversedLinkedList = new LinkedList<int>();
            var currentNode = linkedList.Last;
            
            while (currentNode != null)
            {
                reversedLinkedList.AddLast(currentNode.Value);
                currentNode = currentNode.Previous;
            }

            Console.Write("Reversed LinkedList1: ");
            Console.WriteLine(string.Join(", ", reversedLinkedList));

            //   Without a new LinkedList

            var first = linkedList.First.Next;
            while (true)
            {
                linkedList.AddBefore(linkedList.First, first.Value);
                first = first.Next;
                if (first == null) { break; }
                linkedList.Remove(first.Previous);
            }
            linkedList.RemoveLast();
              
            Console.Write("Reversed LinkedList2: ");
            Console.WriteLine(string.Join(", ", linkedList));
        }
    }
}
