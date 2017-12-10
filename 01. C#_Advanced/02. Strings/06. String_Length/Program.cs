using System;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input += new string('*', 20 - input.Length);

            Console.WriteLine(input);
        }
    }
}
