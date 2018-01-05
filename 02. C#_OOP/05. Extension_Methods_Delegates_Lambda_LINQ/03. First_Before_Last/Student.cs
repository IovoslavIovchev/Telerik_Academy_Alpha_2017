using System;
using System.Collections.Generic;
using System.Text;

namespace First_Before_Last
{
    public class Student
    {
        private string fName, lName;

        public Student(string fName, string lName)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                throw new ArgumentNullException("Student name cannot be null or empty!");
            }
            this.fName = fName;
            this.lName = lName;
        }

        public string FirstName => this.fName;

        public string LastName => this.lName;

        public override string ToString()
        {
            return $"{this.fName} {this.lName}";
        }
    }
}
