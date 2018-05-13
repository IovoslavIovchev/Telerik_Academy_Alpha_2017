using System;
using System.Collections.Generic;
using System.Text;

namespace Range_Exceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private readonly T start;
        private readonly T end;

        public InvalidRangeException(string message) : base(message)
        {
        }
    }
}
