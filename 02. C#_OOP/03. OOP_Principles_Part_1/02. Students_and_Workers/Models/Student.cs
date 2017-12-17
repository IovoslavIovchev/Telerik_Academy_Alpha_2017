using System;
using System.Collections.Generic;
using System.Text;

namespace Students_and_Workers.Models
{
    public class Student : Human
    {
        private double grade; 

        public Student(string firstName, string lastName, double grade) 
            : base(firstName, lastName)
        {
            if (grade < 2 || grade > 6) { throw new ArgumentException("Grade can't be less than 2.00 and more than 6.00"); }

            this.grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
        }

        public override string Info()
        {
            return $"{this.FirstName} {this.LastName} - {this.grade:F2}";
        }
    }
}
