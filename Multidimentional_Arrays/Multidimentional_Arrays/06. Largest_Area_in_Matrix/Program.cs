using System;
using System.Linq;

namespace Largest_Area_in_Matrix
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
        }
    }
}
