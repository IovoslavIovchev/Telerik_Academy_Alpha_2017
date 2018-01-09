using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Sequence
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

                sequence.Add(number);
            }

            Console.WriteLine(string.Join(" ", sequence.OrderBy(x => x)));
        }
    }
}
