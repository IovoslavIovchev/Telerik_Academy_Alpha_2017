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
            string[] text = Console.ReadLine()
                .Split(new string[] {"</a>"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();            

            StringBuilder result = new StringBuilder();
            
            foreach(var t in text)
                result.Append(Regex.Replace(t, "<a href=\"(.*)\">(.*)", x => "[" + x.Groups[2] + "](" + x.Groups[1] + ")"));
            

            Console.WriteLine(result);
        } 
    }
}