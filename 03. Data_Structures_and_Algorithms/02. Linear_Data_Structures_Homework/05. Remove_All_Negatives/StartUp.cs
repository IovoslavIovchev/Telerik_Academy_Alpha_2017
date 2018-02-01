using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_All_Negatives
{
    static class StartUp
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

            Console.WriteLine(string.Join(" ", sequence));

            sequence = sequence.RemoveAllNegatives();

            Console.WriteLine(string.Join(" ", sequence));
        }

        static List<int> RemoveAllNegatives(this List<int> list)
        {
            return list.Where(x => x >= 0).ToList();
        }
    }
}
