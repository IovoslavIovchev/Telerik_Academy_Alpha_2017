using System;

namespace Allocate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
                array[i] = i * 5;
            
            foreach(var num in array)
                Console.WriteLine(num);            
        }
    }
}