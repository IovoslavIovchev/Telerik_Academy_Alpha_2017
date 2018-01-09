using System;
using System.Collections.Generic;
using System.Linq;

namespace Occurence
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

            Dictionary<int, int> occurences = sequence.Occurences();

            foreach (var key in occurences.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{key} -> {occurences[key]} times");
            }
        }

        static Dictionary<int, int> Occurences(this List<int> list)
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

            return occurence;
        }
    }
}
