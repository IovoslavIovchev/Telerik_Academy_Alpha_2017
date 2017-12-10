using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Replace_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            text = Regex.Replace(text, "<a href=\"(.*?)\">(.*?)</a>", x => "[" + x.Groups[2] + "](" + x.Groups[1] + ")");

            Console.WriteLine(text);
        }
    }
}