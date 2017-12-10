using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                Console.Write("\\u" + ((int)ch).ToString("X").PadLeft(4, '0'));
            }
            Console.WriteLine();
        }
    }
}