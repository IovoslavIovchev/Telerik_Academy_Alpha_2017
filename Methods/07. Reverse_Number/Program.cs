using System;
using System.Text;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            Console.WriteLine(ReverseNumber(number));
        }

        static string ReverseNumber(string n)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = n.Length - 1; i >= 0; i--)
                reversed.Append(n[i]);
            
            return reversed.ToString();
        }
    }
}
