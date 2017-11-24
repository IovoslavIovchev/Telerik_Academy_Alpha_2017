using System;
using System.Linq;

namespace Sequence_in_Matrix
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

            int longest = int.MinValue;

            for (int a = 0; a < x; a++)
            {
                int temp = 1;
                int cur = matrix[a][0];

                for (int b = 1; b < y; b++)
                {
                    if (matrix[a][b] == cur)
                        temp++;
                    else
                    {
                        if (temp > longest)
                            longest = temp;
                        cur = matrix[a][b];
                        temp = 1;
                    }
                }

                if (temp > longest)
                    longest = temp;
            }

            for (int b = 0; b < y; b++)
            {
                int temp = 1;
                int cur = matrix[0][b];

                for (int a = 1; a < y; a++)
                {
                    if (matrix[a][b] == cur)
                        temp++;
                    else
                    {
                        if (temp > longest)
                            longest = temp;
                        cur = matrix[a][b];
                        temp = 1;
                    }
                }

                if (temp > longest)
                    longest = temp;
            }

            Console.WriteLine(longest);
        }
    }
}
