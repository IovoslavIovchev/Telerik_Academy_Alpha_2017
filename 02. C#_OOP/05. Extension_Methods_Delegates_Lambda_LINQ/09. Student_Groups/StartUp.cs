using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Groups
{
    static class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Ivan", "Ivan4ov", "121111", "0891111111", "ivan4o@ivan4o.net", new List<double>(){ 2, 5, 6, 6, 2}, 2, "Mathematics"),
                new Student("Pe6o", "Pe6anov", "150406", "0284626846", "pe6o@abv.bg", new List<double>(){ 6, 5, 6, 6}, 1, "Philosophy"),
                new Student("Maria", "Marieva", "050309", "087165151", "mari@marieva.bg", new List<double>(){ 6, 2, 4, 6, 5}, 3, "Informatics"),
                new Student("Dimitri4ka", "Balykova", "180306", "0289474765", "dimi@l06ata.com", new List<double>(){ 2, 5, 2, 2}, 1, "Philosophy"),
            };

            //Only students from Group 2
            List<Student> groupTwoStudents = students.FromGroup(2);
            Console.WriteLine("Group two:\n" + string.Join(Environment.NewLine, groupTwoStudents));

            //All students that have email in 'abv.bg'
            List<Student> abvStudents = students.Where(x => x.Email.EndsWith("abv.bg")).ToList();
            Console.WriteLine("\nStudents with abv.bg email:\n" + string.Join(Environment.NewLine, abvStudents));

            //All students with phones in Sofia
            List< Student> studentsFromSofia = students.Where(x => x.Telephone.StartsWith("02")).ToList();
            Console.WriteLine("\nStudents with phones in Sofia:\n" + string.Join(Environment.NewLine, studentsFromSofia));

            //All students that have at least one mark Excellent 6 in an anonymous class
            var anonymousStudents /*they are not hackers, don't worry*/ = 
                from student in students
                    .Where(x => x.Marks.Contains(6)).ToArray()
                select new { student.FirstName, student.LastName, student.Marks};

            Console.WriteLine("\nAnon Students with Excellent marks:");
            foreach (var anon in anonymousStudents)
            {
                Console.WriteLine($"{anon.FirstName} {anon.LastName}");
            }

            //students[2].AddMark(0); -> throws exception

            //All students with exactly two marks '2'
            List<Student> twoMarksTwoStudents = students.Where(x => x.Marks.Where(y => y == 2).Count() == 2).ToList();
            Console.WriteLine("\nStudents with exactly two marks 2:\n" + string.Join(Environment.NewLine, twoMarksTwoStudents));

            //All students who enrolled in 2006
            List<Student> studentsFrom2006 = students.Where(x => x.FacultyNumber[4] == '0' && x.FacultyNumber[5] == '6').ToList();
            Console.WriteLine("\nStudents from 2006:");
            foreach (Student student in studentsFrom2006)
            {
                Console.WriteLine(student);
                Console.WriteLine($" - Marks: {string.Join(", ", student.Marks.OrderBy(x => x))}");
            }

            //All students from the Mathematics department
            //TODO USE JOIN
        }

        static List<Student> FromGroup(this List<Student> students, int group)
        {
            return students.Where(x => x.GroupNumber == group).OrderBy(x => x.FirstName).ToList();
        }
    }
}
