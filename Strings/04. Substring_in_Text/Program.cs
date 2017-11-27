using System;
using System.Text.RegularExpressions;

namespace Substring_in_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int c = 0;
            for (int i = 0; i < text.Length - pattern.Length; i++)
            {
                int found = text.IndexOf(pattern, i);
                if (found != -1) 
                {
                    c++;                
                    i = found;
                }
            }

            Console.WriteLine(c);
        }
    }
}
