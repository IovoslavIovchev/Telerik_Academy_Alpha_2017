using System;
using System.Collections.Generic;
using System.Linq;

namespace Jedi_Meditation
{
    class StartUp
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] waitingJedi = Console.ReadLine().ToUpper().Split();

            List<string> m = waitingJedi
                .Where(x => x.StartsWith("M"))
                //.OrderByDescending(x => decimal.Parse(x.Substring(1)))
                .ToList();
            List<string> k = waitingJedi
                .Where(x => x.StartsWith("K"))
                //.OrderByDescending(x => decimal.Parse(x.Substring(1)))
                .ToList();
            List<string> p = waitingJedi.Where(x => x.StartsWith("P")).ToList();

            m.AddRange(k);
            m.AddRange(p);

            Console.WriteLine(string.Join(" ", m));
        }
    }
}