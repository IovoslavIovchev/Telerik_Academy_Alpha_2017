using System;
using System.Collections.Generic;
using System.Linq;

class Hops
{
    static void Main(string[] args)
    {
        //Hops by IovoslavIovchev
        int[] carrots = Console.ReadLine()
            .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        short m = short.Parse(Console.ReadLine()); int max = int.MinValue; //directions to try
        for (short i = 0; i < m; i++)
        {
            HashSet<int> visited = new HashSet<int>();
            int[] directions = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int position = 0, temp = 0, x = 0;
            while (!visited.Contains(position))
            {
                if (position < 0 || position >= carrots.Length)
                    break;

                temp += carrots[position];
                visited.Add(position);

                position += directions[x++];

                if (x == directions.Length)
                    x = 0;
            }
            if (max < temp)
                max = temp;
        }

        Console.WriteLine(max);
    }
}
