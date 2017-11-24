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

            string[,] matrix = new string[x, y];

            for (int i = 0; i < x; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            int max = int.MinValue;

            for (int i = 0; i < x; i++)
            {
                int temp = 1;
                string cur = matrix[i, 0];

                for (int j = 1; j < y; j++)
                {
                    if (matrix[i, j].Equals(cur))
                        temp++;
                    else
                    {
                        if (max < temp)
                            max = temp;
                        cur = matrix[i, j];
                        temp = 1;
                    }
                }
                if (max < temp)
                    max = temp;
            }

            for (int j = 0; j < y; j++)
            {
                int temp = 1;
                string cur = matrix[0, j];

                for (int i = 1; i < x; i++)
                {
                    if (matrix[i, j].Equals(cur))
                        temp++;
                    else
                    {
                        if (max < temp)
                            max = temp;
                        cur = matrix[i, j];
                        temp = 1;
                    }
                }
                if (max < temp)
                    max = temp;
            }

            for (int i = 0, j = 0; i < x || j < y;)
            {
                int temp = 1;
                string cur = matrix[i, j];
                                
                for (int f = i+1, h = j+1; f < x || h < y;)
                {
                    if (matrix[f++, h++].Equals(cur))
                        temp++;
                    else
                    {
                        cur = matrix[f++, h++];
                        temp = 1;
                    }
                }
                j++;
            }
        }
    }
}
