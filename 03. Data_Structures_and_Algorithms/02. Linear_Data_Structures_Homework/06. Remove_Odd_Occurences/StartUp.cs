using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Odd_Occurences
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

            List<int> newList = sequence.RemoveOddOccurences();

            Console.WriteLine(string.Join(" ", newList));
        }

        static List<int> RemoveOddOccurences(this List<int> list)
        {
            Dictionary<int, int> occurence = new Dictionary<int, int>();

            foreach (int num in list)
            {
                if (!occurence.ContainsKey(num))
                {
                    occurence.Add(num, 0);
                }
                occurence[num]++;
            }

            return list.Where(x => occurence[x] % 2 == 0).ToList();
        }
    }
}
