using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Expressions
{
    class StartUp
    {
        private static int N;

        private static int count = 0;

        public static void Main()
        {
            string number = Console.ReadLine();
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i < number.Length; i++)
            {
                int tempNum = int.Parse(number.Substring(i - 1, i));
                string restOfNum = number.Substring(i);

                Recurse(restOfNum, tempNum);
            }

            Console.WriteLine(count);
        }

        private static void Recurse(string number, int total)
        {
            if (number == string.Empty)
            {
                Debug.WriteLine(total); //Remove
                if (total == N) count++;
                
                return;
            }

            for (int i = number.Length; i > -1; i--)
            {
                string temp = number.Substring(0, i);
                string restOfNum = number.Substring(i);

                if (temp.Length > 1 && temp[0] == '0')
                {
                    continue;
                }

                if (temp == string.Empty) return;

                int tempNum = int.Parse(temp);

                Recurse(restOfNum, total * tempNum);
                Recurse(restOfNum, total + tempNum);
                Recurse(restOfNum, total - tempNum);
            }
        }
    }
}
