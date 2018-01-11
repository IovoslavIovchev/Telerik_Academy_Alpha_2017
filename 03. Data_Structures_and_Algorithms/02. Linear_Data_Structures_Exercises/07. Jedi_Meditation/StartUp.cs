using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Meditation
{
    class StartUp
    {
        static void Main()
        {
            Console.ReadLine();
            string[] waitingJedi = Console.ReadLine().Split();

            Queue<string> m = new Queue<string>();
            Queue<string> k = new Queue<string>();
            Queue<string> p = new Queue<string>();

            for (int i = 0; i < waitingJedi.Length; i++)
            {
                switch (waitingJedi[i][0])
                {
                    case 'M': m.Enqueue(waitingJedi[i]);
                        break;
                    case 'K': k.Enqueue(waitingJedi[i]);
                        break;
                    case 'P': p.Enqueue(waitingJedi[i]);
                        break;
                }
            }

            Console.WriteLine($"{string.Join(" ", m)} {string.Join(" ", k)} {string.Join(" ", p)}");
        }
    }
}