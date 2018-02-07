using System;
using System.Collections.Generic;
using System.Text;

namespace Age_Range
{
    public class Student
    {
        private string fName, lName;
        private int age;

        public Student(string fName, string lName, int age)
        {
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                throw new ArgumentNullException("Student name cannot be null or empty!");
            }
            if (age < 7 || age > 69)
            {
                throw new ArgumentException("Invalid Student age!");
            }
            this.fName = fName;
            this.lName = lName;
            this.age = age;
        }

        public string FirstName => this.fName;

        public string LastName => this.lName;

        public int Age => this.age;

        public override string ToString()
        {
            return $"{this.fName} {this.lName}";
        }
    }
}
