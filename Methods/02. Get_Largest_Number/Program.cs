using System;
using System.Linq;

namespace Get_Largest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int max = GetMax(GetMax(numbers[0], numbers[1]), 
                             GetMax(numbers[1], numbers[2]));

            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
                return a;

            return b;
        }
    }
}
