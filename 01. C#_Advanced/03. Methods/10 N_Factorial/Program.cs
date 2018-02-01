using System;
using System.Numerics;

namespace N_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(N));
        }

        static BigInteger Factorial(int N)
        {
            BigInteger F = 1;
            for (int i = N; i > 1; i--)
                F *= i;

            return F;
        }
    }
}
