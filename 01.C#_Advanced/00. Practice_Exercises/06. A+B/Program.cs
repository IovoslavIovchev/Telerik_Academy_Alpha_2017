using System;
using System.Linq;

namespace A_plus_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                int[] temp = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                array[i] = temp[0] + temp[1];
            }

            foreach(var num in array)
                Console.WriteLine(num);
        }
    }
}