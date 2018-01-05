using System;
using System.Collections.Generic;

namespace Prime_Numbers_in_Interval
{
    class StartUp
    {
        static void Main()
        {
            List<int> primes = CheckPrimes();

            Console.WriteLine("Primes in the range 200-300:");
            Console.WriteLine(string.Join(", ", primes));
        }

        static List<int> CheckPrimes()
        {
            List<int> list = new List<int>();

            for (int i = 200; i <= 300; i++)
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
                    list.Add(i);
                }
            }

            return list;
        }
    }
}
