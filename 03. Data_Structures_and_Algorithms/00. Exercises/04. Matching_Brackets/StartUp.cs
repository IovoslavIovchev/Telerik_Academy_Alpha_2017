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
            //expression = "5 * (4 - 67) + ((3 - 5) * 4)";

            int matches = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i].Equals('('))
                {
                    matches++;
                }
                if (expression[i].Equals(')'))
                {
                    matches--;
                }
            }

            if (matches != 0)
            {
                Console.WriteLine("Invalid brace count in expression");
                return;
            }

            Stack<int> positions = new Stack<int>();
            StringBuilder temp = new StringBuilder();
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
                    temp.Clear();
                    int start = positions.Pop();
                    int last = i;

                    result.Add(expression.Substring(start, last - start + 1));
                }
            }

            Console.WriteLine(string.Join(" | ", result));
        }
    }
}
