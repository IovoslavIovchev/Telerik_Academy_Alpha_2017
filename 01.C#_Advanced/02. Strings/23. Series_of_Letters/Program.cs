using System;
using System.Text;

namespace Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 1; i < input.Length; i++)
            {
                if (!input[i].Equals(input[i - 1]))
                    result.Append(input[i - 1]);                
            }
            result.Append(input[input.Length - 1]);

            Console.WriteLine(result);
        }
    }
}
