using System;
using System.Linq;
using System.Numerics;

namespace Bit_Shift_Matrix
{
    class Program
    {
        static BigInteger sum = 0;
        static BigInteger[,] m;
        static int X, Y;
        static void Main(string[] args)
        {
            ushort a = ushort.Parse(Console.ReadLine()),
                   b = ushort.Parse(Console.ReadLine()), 
                   COEFF = Math.Max(a, b);

            m = new BigInteger[a, b];

            for (int i = a - 1; i >= 0; i--)
            {
                for (int j = 0; j < b; j++)
                {
                    m[i, j] = (BigInteger)Math.Pow(2, (a + j - i - 1));
                }
            }

            X = a - 1; Y = 0;

            ushort N = ushort.Parse(Console.ReadLine());
            decimal[] CODEs = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            for (int i = 0; i < N; i++)
            {
                int r = (int)CODEs[i] / COEFF;
                int c = (int)CODEs[i] % COEFF;

                GoTo(r, c);
            }

            Console.WriteLine(sum);
        }

        static void GoTo(int r, int c)
        {
            int start = Math.Min(c, Y), end = Math.Max(c, Y);

            for (int j = start; j <= end; j++)
            {
                sum += m[X, j]; m[X, j] = 0;
            }
            if (c == end) Y = end;
            else Y = start;

            start = Math.Min(r, X); end = Math.Max(r, X);
            for (int j = start; j <= end; j++)
            {
                sum += m[j, Y]; m[j, Y] = 0;
            }
            if (r == end) X = end;
            else X = start;
        }
    }
}