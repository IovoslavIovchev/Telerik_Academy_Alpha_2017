using System;

namespace Exchange_if_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine()),
                   B = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(A, B) + " " + Math.Max(A, B));
        }
    }
}
