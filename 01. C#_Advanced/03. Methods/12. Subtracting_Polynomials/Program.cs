using System;
using System.Linq;

namespace Subtracting_Polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = new int[int.Parse(Console.ReadLine())];
            int[] first = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] second = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            SubPolynomials(first, second, result);

            Console.WriteLine(string.Join(" ", result));

            MultiplyPolynomials(first, second, result);

            Console.WriteLine(string.Join(" ", result));
            
        }

        static void SubPolynomials (int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < result.Length; i++)
                result[i] = first[i] - second[i];
        }

        static void MultiplyPolynomials (int[] first, int[] second, int[] result)
        {
            for (int i = 0; i < result.Length; i++)
                result[i] = first[i] * second[i];
        }
    }
}
