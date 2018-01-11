using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Timer
{
    public static class Timer
    {        
        public static void TimedExecute(StartUp.Action action, int t, int times)
        {
            int c = 0;
            while (++c < times)
            {
                Wait(t);
                action();
            }
        }

        private static void Wait(int t)
        {
            Thread.Sleep(t * 1000);
        }
    }
}
