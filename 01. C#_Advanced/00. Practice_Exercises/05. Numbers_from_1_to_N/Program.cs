using System;

namespace Numbers_from_1_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
