using System;
using System.Collections.Generic;

namespace Longest_Subsequence
{
    static class StartUp
    {
        static void Main()
        {
            List<int> sequence = new List<int>();

            string input;
            while (!(input = Console.ReadLine()).Equals(string.Empty))
            {
                int number = int.Parse(input);

                sequence.Add(number);
            }

            List<int> subsequence = sequence.LongestSubsequence();

            Console.WriteLine(string.Join(" ", subsequence));
        }

        static List<int> LongestSubsequence(this List<int> list)
        {
            int bestStart = 0, bestLength = 0;
            int start = 0, length = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i-1])
                {
                    length++;
                }
                else
                {
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = start;
                    }
                    start = i;
                    length = 1;
                }
            }

            return list.GetRange(bestStart, bestLength);
        }
    }
}
