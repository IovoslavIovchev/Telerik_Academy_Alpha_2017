using System;
using System.Threading;

namespace Timer
{
    public class StartUp
    {
        public delegate void Action();

        static void Main()
        {
            Action timedSayHello = new Action(SayHi);

            Timer.TimedExecute(timedSayHello, 1, 100);
        }

        static void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
