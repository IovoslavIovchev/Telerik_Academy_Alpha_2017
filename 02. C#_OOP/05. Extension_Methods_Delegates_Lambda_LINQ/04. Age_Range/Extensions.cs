using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Age_Range
{
    public static class Extensions
    {
        public static Student[] AgeRange(this Student[] students)
        {
            return students.Where(x => x.Age >= 18 && x.Age <= 24).ToArray();
        }
    }
}
