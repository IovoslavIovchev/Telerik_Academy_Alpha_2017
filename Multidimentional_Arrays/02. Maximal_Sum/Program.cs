using System;
using System.Linq;
using System.Timers;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int x = size[0], y = size[1];

            short[][] matrix = new short[x][];
            for (int i = 0; i < x; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(short.Parse)
                    .ToArray();
            }

            int max = int.MinValue;

            for (int a = 1; a < x - 1; a++)
            {
                for (int b = 1; b < y - 1; b++)
                {
                    int temp = 0;

                    for (int c = a - 1; c <= a + 1; c++)
                    {
                        for (int d = b - 1; d <= b + 1; d++)
                        {
                            temp += matrix[c][d];
                        }
                    }

                    if (temp > max)
                        max = temp;
                }
            }

            Console.WriteLine(max);
        }
    }
}
