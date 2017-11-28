using System;
using System.Linq;

namespace Number_as_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray().Max();

            int[] first = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] second = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] result = new int[max + 1];
            
            AddToArray(result, first);
            AddToArray(result, second);

            if (result[result.Length-1] == 0)
                Console.WriteLine(string.Join(" ", result.Take(result.Length - 1)));
            else
                Console.WriteLine(string.Join(" ", result));
        }

        static void AddToArray(int[] result, int[] array)
        {
            int rem = 0;
            for (int i = 0; i < array.Length; i++)
            {                
                result[i] += array[i] + rem;

                if (result[i] >= 10)
                {
                    rem = 1;
                    result[i] -= 10;
                }            
                else
                    rem = 0;
            }

            result[result.Length - 1] += rem;
        }
    }
}
