using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divisible_by_7_and_3
{
    public static class Extensions
    {
        public static int[] Divisible(this int[] array)
        {
            return array.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();
        }
    }
}
