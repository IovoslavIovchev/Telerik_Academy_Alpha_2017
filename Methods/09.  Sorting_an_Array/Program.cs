using System;
using System.Linq;

namespace Sorting_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            SortNums(N, numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void SortNums(int N, int[] nums)
        {
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        nums[i] += nums[j];
                        nums[j] = nums[i] - nums[j];
                        nums[i] -= nums[j];
                    }
                }
            }
        }
    }
}
