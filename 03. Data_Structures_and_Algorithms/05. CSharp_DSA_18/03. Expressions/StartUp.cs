using System;
using System.Collections.Generic;

namespace Expressions
{
    class StartUp
    {
        static string numbers;

        static int N;

        static int max;

        static void Main()
        {
            numbers = Console.ReadLine();
            N = int.Parse(Console.ReadLine());
            max = 0;

            Recurse(numbers);

            Console.WriteLine(max);
        }

        static void Recurse(string input, int result = 0)
        {
            if (input.StartsWith("0")) return;

            if (result == N)
            {
                max++;
                return;
            }

            for (int i = 1; i < input.Length + 1; i++)
            {
                int current = int.Parse(input.Substring(0, i));
                string next = input.Substring(i);

                Console.WriteLine($"{current} {next}");

                Recurse(next, result * current);
                Recurse(next, result + current);
                Recurse(next, result - current);
            }
        }
    }
}
