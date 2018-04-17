using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students_Order
{
    class StartUp
    {
        private static LinkedList<string> students;

        private static Dictionary<string, LinkedListNode<string>> namedStudents;

        private static int GetVariations()
        {
            students = new LinkedList<string>();
            namedStudents = new Dictionary<string, LinkedListNode<string>>();

            return Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()[1];
        }

        private static void GetStudents()
        {
            string[] args = Console.ReadLine().Split();

            for (int i = 0; i < args.Length; i++)
            {
                students.AddLast(args[i]);
                namedStudents.Add(args[i], students.Last);
            }
        }

        private static void SwapStudents(LinkedListNode<string> left, LinkedListNode<string> right)
        {
            students.Remove(left);

            students.AddBefore(right, left);
        }

        static void Main()
        {
            int K = GetVariations();

            GetStudents();

            for (int i = 0; i < K; i++)
            {
                string[] swapees = Console.ReadLine().Split();

                SwapStudents(namedStudents[swapees[0]], namedStudents[swapees[1]]);
            }

            var a = students.First;
            StringBuilder b = new StringBuilder();
            while (a != null)
            {
                b.Append($"{a.Value} ");
                a = a.Next;
            }


            Console.WriteLine(b);
        }
    }
}