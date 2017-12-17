using System;
using System.Collections.Generic;
using System.Linq;
using Students_and_Workers.Models;

namespace Students_and_Workers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Go6o", "Go6ov1", 4.20),
                new Student("Go6o", "Go6ov2", 6.00),
                new Student("Go6o", "Go6ov3", 2.20),
                new Student("Go6o", "Go6ov4", 3.56),
                new Student("Go6o", "Go6ov5", 2.99),
                new Student("Go6o", "Go6ov6", 3.00),
                new Student("Go6o", "Go6ov7", 5),
                new Student("Go6o", "Go6ov8", 5.20),
                new Student("Go6o", "Go6ov9", 3.80),
                new Student("Go6o", "Go6ov10", 4.20),
            };

            foreach (Student st in students.OrderBy(x => x.Grade))
            {
                Console.WriteLine(st.Info());
            }

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Pe6o", "Pe6ov1", 400M, 8),
                new Worker("Pe6o", "Pe6ov2", 130M, 4),
                new Worker("Pe6o", "Pe6ov3", 560M, 8),
                new Worker("Pe6o", "Pe6ov4", 740M, 8),
                new Worker("Pe6o", "Pe6ov5", 496M, 6),
                new Worker("Pe6o", "Pe6ov6", 1000M, 212),
                new Worker("Pe6o", "Pe6ov7", 420M, 8),
                new Worker("Pe6o", "Pe6ov8", 460M, 8),
                new Worker("Pe6o", "Pe6ov9", 100M, 4),
                new Worker("Pe6o", "Pe6ov10", 530M, 8)
            };

            foreach (Worker worker in workers.OrderByDescending(x => x.MoneyPerHour()))
            {
                Console.WriteLine(worker.Info());
            }

            List<Human> mixed = new List<Human>();
            mixed.AddRange(students);
            mixed.AddRange(workers);

            foreach (Human human in mixed.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
            {
                Console.WriteLine(human.Info());
            }
        }
    }
}
