using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Timer
{
    public static class Timer
    {
        public static void Wait(int t)
        {
            Thread.Sleep(t * 1000);
        }
    }
}
