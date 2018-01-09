using System;
using System.Collections.Generic;
using System.Text;

namespace Matching_Brackets
{
    class StartUp
    {
        static void Main()
        {
            string expression = Console.ReadLine();

            //NO NEED FOR THIS

            //int matches = 0;
            //for (int i = 0; i < expression.Length; i++)
            //{
            //    if (expression[i].Equals('('))
            //    {
            //        matches++;
            //    }
            //    if (expression[i].Equals(')'))
            //    {
            //        matches--;
            //    }
            //}
            //
            //if (matches != 0)
            //{
            //    Console.WriteLine("Invalid brace count in expression");
            //    return;
            //}

            Stack<int> positions = new Stack<int>();
            List<string> result = new List<string>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('('))
                {
                    positions.Push(i);
                    continue;
                }

                if (expression[i].Equals(')'))
                {
                    int start = positions.Pop();

                    result.Add(expression.Substring(start, i - start + 1));
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
