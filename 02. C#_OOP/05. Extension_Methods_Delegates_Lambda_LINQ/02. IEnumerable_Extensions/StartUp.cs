using System;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable_Extensions
{
    class StartUp
    {
        static void Main()
        {
            List<double> f = new List<double> { 1.8, 2, 3 };

            var t = f.Average();

            Console.WriteLine(t);
        }
    }
}
