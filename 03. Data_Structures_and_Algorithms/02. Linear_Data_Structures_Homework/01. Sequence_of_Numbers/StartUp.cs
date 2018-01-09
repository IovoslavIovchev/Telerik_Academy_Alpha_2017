using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequence_of_Numbers
{
    class StartUp
    {
        static void Main()
        {
            List<int> sequence = new List<int>();

            string input;
            while (!(input = Console.ReadLine()).Equals(string.Empty))
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number must be positive");
                    continue;
                }

                sequence.Add(number);
            }

            Console.WriteLine($"Sum of sequence: {sequence.Sum()}\nAverage of sequence: {sequence.Average()}");
        }
    }
}
