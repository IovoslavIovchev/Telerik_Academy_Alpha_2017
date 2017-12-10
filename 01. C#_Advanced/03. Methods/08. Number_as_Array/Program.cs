using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
 
namespace Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string f = string.Join("", Console.ReadLine().Split().ToArray());
            string s = string.Join("", Console.ReadLine().Split().ToArray());
            
            int max = Math.Max(f.Length, s.Length);

            f = f.PadRight(max, '0');
            s = s.PadRight(max, '0');

            Console.WriteLine(SumArrays(f, s, max));
        } 

        static string SumArrays(string f, string s, int max)
        {
            StringBuilder result = new StringBuilder();

            int rem = 0;
            int num = 0;

            for (int i = 0; i < max; i++)
            {
                int temp = f[i] + s[i] - 96 + rem;
                rem = temp / 10;
                num = temp % 10;
                result.Append(num.ToString()+ " ");
            }

            return result.ToString().Trim();
        }
    }
}