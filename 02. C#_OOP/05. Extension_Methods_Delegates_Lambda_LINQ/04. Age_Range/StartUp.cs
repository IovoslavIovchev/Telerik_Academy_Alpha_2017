using System;

namespace Age_Range
{
    class StartUp
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Go6o", "Petkanov", 8),
                new Student("Joro", "JoroF", 21),
                new Student("Stamat", "Doikin", 12),
                new Student("Dimitri4ka", "Dimitri4kova", 18)
            };

            Student[] drugiStudents = students.AgeRange();

            foreach (Student s in drugiStudents)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
