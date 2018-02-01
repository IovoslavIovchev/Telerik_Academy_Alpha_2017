using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Students
{
    public static class Extensions
    {
        public static void LambdaOrder(this Student[] students)
        {
            var orderedStudents = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();

            foreach (Student s in orderedStudents)
            {
                Console.WriteLine(s.ToString());
            }
        }

        public static void LinqKeywordsOrder(this Student[] students)
        {
            var orderedStudents = from student in students
                orderby student.FirstName descending
                select student;

            foreach (Student s in orderedStudents)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
