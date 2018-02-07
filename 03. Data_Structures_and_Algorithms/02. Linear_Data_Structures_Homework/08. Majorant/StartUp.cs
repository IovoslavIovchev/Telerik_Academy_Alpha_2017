using System;
using System.Collections.Generic;
using System.Linq;

namespace Majorant
{
    static class StartUp
    {
        static void Main()
        {
            int[] sequence = Console.ReadLine() 
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();

            bool hasMajorant = sequence.HasMajorant();

            Console.WriteLine(hasMajorant ? $"Majorant in sequence: {sequence[sequence.Length/2-1]}" : "The sequence has no majorant!");
        }

        static bool HasMajorant(this int[] array)
        {
            int median = array.Length / 2 - 1;

            return array[median] == array[median - 1] && array[median] == array[median + 1];
        }
    }
}
