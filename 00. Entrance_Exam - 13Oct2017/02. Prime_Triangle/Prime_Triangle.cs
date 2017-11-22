using System;
using System.Collections.Generic;

namespace Prime_Triangle
{
    class Prime_Triangle
    {
        static void Main(string[] args)
        {
            //Prime Triangle by IovoslavIovchev
            int n = int.Parse(Console.ReadLine());
            List<int> primes = IsPrime(n);

            for (int i = 1; i <= n; i++)
            {
                if (!primes.Contains(i))
                    continue;

                for (int j = 1; j <= i; j++)
                {
                    if (primes.Contains(j))
                        Console.Write(1);

                    else
                        Console.Write(0);
                }
                Console.WriteLine();
            }
        }

        static List<int> IsPrime(int g)
        {
            List<int> primes = new List<int>();
            primes.Add(1);
            for (int i = 1; i <= g; i++)
            {
                int ctrl = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctrl++;
                        break;
                    }
                }

                if (ctrl == 0 && i != 1)
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
