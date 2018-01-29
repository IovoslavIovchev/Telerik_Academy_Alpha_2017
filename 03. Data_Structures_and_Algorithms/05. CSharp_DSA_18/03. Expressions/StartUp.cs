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

            for (int i = 1; i <= number.Length; i++)
            {
                int tempNum = int.Parse(number.Substring(0, i));
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

            int temp = int.Parse(number[0].ToString());
            string restOfNum = number.Substring(1);

            Recurse(restOfNum, total * temp);
            Recurse(restOfNum, total + temp);
            Recurse(restOfNum, total - temp);

            if (restOfNum == string.Empty) return;
            int parsedRest = int.Parse(restOfNum);

            Recurse(string.Empty, total * parsedRest);
            Recurse(string.Empty, total + parsedRest);
            Recurse(string.Empty, total - parsedRest);
        }
    }
}
