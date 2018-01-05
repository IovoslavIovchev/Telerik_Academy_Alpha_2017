using System;
using System.Linq;
using System.Collections.Generic;

namespace Order_Students
{
    class StartUp
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Go6o", "Petkanov", 8),
                new Student("Joro", "Go6ov", 21),
                new Student("Joro", "Aleksandrov", 19),
                new Student("Alex", "Umrqlkov", 32),
                new Student("Ri4o", "Doikin", 12),
                new Student("Dimitri4ka", "Dimitri4kova", 18),
                new Student("Gruyo", "Minkov", 40)
            };

            students.LambdaOrder();

            Console.WriteLine();

            students.LinqKeywordsOrder();
        }
    }
}
