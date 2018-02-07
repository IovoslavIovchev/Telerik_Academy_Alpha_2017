using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Slogan
{
    class StartUp
    {
        static List<string> slogans;

        static StringBuilder result;

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            slogans = new List<string>();
            result = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                string[] words = Console.ReadLine().Split();
                string slogan = Console.ReadLine();
                slogans.Clear();

                if (ValidateSlogan(slogan, words, new HashSet<string>()))
                {
                    slogans.Reverse();
                    result.AppendLine(string.Join(" ", slogans));
                }
                else
                {
                    result.AppendLine("NOT VALID");
                }
            }

            Console.Write(result);
        }

        static bool ValidateSlogan(string slogan, string[] words, HashSet<string> impossibleSlogans)
        {
            if (slogan == string.Empty)
            {
                return true;
            }

            if (impossibleSlogans.Contains(slogan))
            {
                return false;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (slogan.StartsWith(words[i]) && ValidateSlogan(slogan.Substring(words[i].Length), words, impossibleSlogans))
                {
                    slogans.Add(words[i]);
                    return true;
                }
            }

            impossibleSlogans.Add(slogan);
            return false;
        }
    }
}
