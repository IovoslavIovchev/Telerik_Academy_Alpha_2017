using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());

            Console.WriteLine(text);
        }
    }
}
