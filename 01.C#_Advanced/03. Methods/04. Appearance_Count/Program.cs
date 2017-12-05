using System;
using System.Collections.Generic;
using System.Linq;

namespace Appearance_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberOccurence(x, numbers));
        }

        static int NumberOccurence(int x, long[] nums)
        {
            if (!nums.Contains(x))
                return 0;
                
            Dictionary<long, int> occurence = new Dictionary<long, int>();
            foreach(var num in nums)
            {
                if (occurence.ContainsKey(num))
                    occurence[num]++;
                else
                    occurence.Add(num, 1);
            }

            return occurence[x];
        }
    }
}
