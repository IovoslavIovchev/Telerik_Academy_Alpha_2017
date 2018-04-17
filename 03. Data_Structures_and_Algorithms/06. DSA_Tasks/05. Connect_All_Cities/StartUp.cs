using System;
using System.Collections.Generic;
using System.Linq;

namespace Connect_All_Cities
{
    class StartUp
    {
        private static int[,] cities;

        private static void TestCities()
        {
            int N = int.Parse(Console.ReadLine());

            cities = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < N; j++)
                {
                    cities[i, j] = temp[j];
                }
            }
        }

        public static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                TestCities();
            }
        }
    }
}