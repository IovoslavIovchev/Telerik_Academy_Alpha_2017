using System;
using System.Linq;

namespace First_Larger_Than_Neighbours
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

            Console.WriteLine(FirstLargerThanNeighbours(N, numbers));
        }

        static short FirstLargerThanNeighbours(int N, long[] nums)
        {
            for (short i = 1; i < N - 1; i++)
            {
                if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1])
                    return i;
            }

            return -1;
        }
    }
}
