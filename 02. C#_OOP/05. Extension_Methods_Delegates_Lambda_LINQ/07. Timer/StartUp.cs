using System;
using System.Threading;

namespace Timer
{
    public class StartUp
    {
        public delegate void Action(int t);

        static void Main()
        {
            Action executeTimer = new Action(Timer.Wait);
            executeTimer += PrintNumber;

            int counter = 0;
            while (counter++ < 20)
            {
                executeTimer(counter);
            }
        }

        static void PrintNumber(int num)
        {
            Console.WriteLine(num);
        }
    }
}
