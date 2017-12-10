using System;
using System.Linq;

namespace Integer_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            Console.WriteLine(Min(numbers));
            Console.WriteLine(Max(numbers));
            Console.WriteLine(Avg(numbers).ToString("0.00"));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));            
        }

        static long Min(long[] nums)
        {
            long min = long.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
            }
            return min;
        }
        static long Max(long[] nums)
        {
            long max = long.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
        static decimal Avg(long[] nums)
        {
            decimal avg = 0;
            for (int i = 0; i < nums.Length; i++)
                avg += nums[i];
            return avg / nums.Length;
        }
        static long Sum(long[] nums)
        {
            long sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];            
            return sum;
        }
        static long Product(long[] nums)
        {
            long product = 1;
            for (int i = 0; i < nums.Length; i++)
                product *= nums[i];
            return product;
        }
    }
}
