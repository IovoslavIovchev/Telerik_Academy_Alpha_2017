using System;

namespace Divisible_by_7_and_3
{
    class StartUp
    {
        static void Main()
        {
            int[] example = new int[] { 21, 3, 63, 7, 234, 217 };

            int[] result = example.Divisible();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
