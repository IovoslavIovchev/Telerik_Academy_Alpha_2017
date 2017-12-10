using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Yesterday
{
    class Program
    {
        static void Main()
        {
            //Yesterday by IovoslavIovchev
            StringBuilder date = new StringBuilder();
            date.Append(Console.ReadLine() + "-");
            date.Append(Console.ReadLine() + "-");
            date.Append(Console.ReadLine());

            DateTime today = DateTime.Parse(date.ToString());
            DateTime yesterday = today.AddDays(-1);

            Console.WriteLine(yesterday.ToString("d-MMM-yyyy"));
        }
    }
}