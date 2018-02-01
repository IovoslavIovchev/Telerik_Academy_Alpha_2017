using System;
using System.Text;

namespace StringBuilder_Substring
{
    class StartUp
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder("some random text");

            string some = input.Substring(0, 4).ToString();
            string random = input.Substring(5, 6).ToString();
            string text = input.Substring(12).ToString();

            Console.WriteLine(some);
            Console.WriteLine(random);
            Console.WriteLine(text);
        }
    }
}
