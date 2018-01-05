using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First_Before_Last
{
    public static class Extensions
    {
        public static Student[] FirstBeforeLast(this Student[] students)
        {
            return students.Where(x => string.Compare(x.FirstName, x.LastName) == -1).ToArray();
        }
    }
}
