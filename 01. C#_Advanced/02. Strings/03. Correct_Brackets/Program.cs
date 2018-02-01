using System;
using System.Text.RegularExpressions;

namespace Correct_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection leftBracket = Regex.Matches(input, @"\(");
            MatchCollection rightBracket = Regex.Matches(input, @"\)");

            if (leftBracket.Count == rightBracket.Count)
            {
                Console.WriteLine("Correct");
                return;
            }

            Console.WriteLine("Incorrect");
        }
    }
}
