using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Groups
{
    public class Student
    {
        private string fName;
        private string lName;
        private string facultyNum;
        private string telephone;
        private string email;
        private List<double> marks;
        private Group group;

        public Student(string fName, string lName, string facultyNum, string telephone, string email, List<double> marks, int groupNum, string department)
        {
            this.fName = fName;
            this.lName = lName;
            this.facultyNum = facultyNum;
            this.telephone = telephone;
            this.email = email;
            this.marks = marks;
            this.group = new Group(groupNum, department);
        }

        public string FirstName => fName; 

        public string LastName => lName; 

        public string FacultyNumber => facultyNum; 

        public string Telephone => telephone; 

        public string Email => email;

        public List<double> Marks
        {
            get => marks;

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Mark can't be null");
                }

                this.marks = value;
            }
        }

        public int GroupNumber => this.group.GroupNumber;

        public string Department => this.group.DepartmentName;

        public void AddMark(double mark)
        {
            if (mark < 2 || mark > 6)
            {
                throw new ArgumentException("Marks must be between 2.00 and 6.00!");
            }

            this.marks.Add(mark);
        }

        public override string ToString()
        {
            return $"{this.fName} {this.lName} - {this.facultyNum}";
        }
    }
}
