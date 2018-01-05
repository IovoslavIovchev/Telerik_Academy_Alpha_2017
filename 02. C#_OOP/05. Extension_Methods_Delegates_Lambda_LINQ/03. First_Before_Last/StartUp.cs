using System;

namespace First_Before_Last
{
    class StartUp
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Go6o", "AngeloF"),
                new Student("Ivan", "Ivbn"),
                new Student("Pe6o", "Malinkin"),
                new Student("Alex", "Qvorov")
            };

            Student[] drugiStudents = students.FirstBeforeLast();

            foreach (Student s in drugiStudents)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
