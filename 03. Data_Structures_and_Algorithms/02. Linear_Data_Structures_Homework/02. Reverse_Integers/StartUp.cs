using System;
using System.Collections.Generic;

namespace Reverse_Integers
{
    class StartUp
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            string input;
            while (!(input = Console.ReadLine()).Equals(string.Empty))
            {
                int number = int.Parse(input);

                numbers.Push(number);
            }

            while (numbers.Count != 0)
            {
                Console.Write($"{numbers.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
