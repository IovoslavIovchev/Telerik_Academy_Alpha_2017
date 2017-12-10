using System;
using System.Linq;

namespace Larger_Than_Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Console.WriteLine(LargerThanNeighbours(N, numbers));
        }

        static short LargerThanNeighbours(int N, long[] nums)
        {
            short Max = 0;
            for (int i = 1; i < N - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                    Max++;
            }

            return Max;
        }
    }
}
