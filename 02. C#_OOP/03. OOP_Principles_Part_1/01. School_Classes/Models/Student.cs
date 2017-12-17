using System;
using System.Collections.Generic;
using System.Text;

namespace School_Classes.Models
{
    public class Student : Person
    {
        private int classNum;
        private string comment;

        public Student(string firstName, string lastName, int classNum) 
            : base(firstName, lastName)
        {
            this.classNum = classNum;
            this.comment = string.Empty;
        }

        public Student(string firstName, string lastName, int classNum, string comment)
            : this(firstName, lastName, classNum)
        {
            this.comment = comment;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNum;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
        }
    }
}
