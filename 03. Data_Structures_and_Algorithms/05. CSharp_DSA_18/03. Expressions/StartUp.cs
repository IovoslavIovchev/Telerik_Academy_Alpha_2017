using System;
using System.Numerics;
using System.Collections.Generic;
using System.Diagnostics;

namespace Expressions
{
    class StartUp
    {
        static List<string> result = new List<string>();

        public static void Main()
        {
            string number = Console.ReadLine();
            BigInteger N = BigInteger.Parse(Console.ReadLine());

            Recurse(number, 0, N, 0, 0, string.Empty);


        }

        private static void Recurse(string num, int start, BigInteger N, BigInteger curSum, BigInteger preNum, string curResult)
        {
            if (start == num.Length)
            {
                if(curSum == N)
                    result.Add(curResult);

                return;
            }

            for (int i = start; i < num.Length; i++)
            {
                string temp = num.Substring(start, i);
                if (temp.Length > 1 && temp[0] == '0')
                {
                    break;
                }
                if (temp.Length == 0)
                {
                    break;
                }

                BigInteger curNum = BigInteger.Parse(temp);

                if (curResult.Length == 0)
                {
                    Recurse(num, i + 1, N, curNum, curNum, curResult);
                }
                else
                {
                    Recurse(num, i + 1, N, curSum - preNum + curSum * preNum, preNum * curSum, $"{curResult}*{curNum}");
                    Recurse(num, i + 1, N, curSum + curNum, curNum, $"{curResult}+{curNum}");
                    Recurse(num, i + 1, N, curSum - curNum, -curNum, $"{curResult}-{curNum}");
                }
            }
        }
    }
}
