using System;
using System.Linq;

namespace Longest_String
{
    static class StartUp
    {
        static void Main()
        {
            string[] strings = { "go6o", "ivan", "pe6o123456789", "go6o2", "asdwefsrbd" };

            string longest = strings.Longest();

            Console.WriteLine(longest);
        }

        static string Longest(this string[] array)
        {
            return array.OrderByDescending(x => x.Length).Take(1).ToArray()[0];
        }
    }
}
