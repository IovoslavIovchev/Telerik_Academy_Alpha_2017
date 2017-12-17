using System;
using System.Collections.Generic;
using System.Text;

namespace School_Classes.Models
{
    public class Class
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string identifier;
        private string comment;

        public Class(List<Teacher> teachers, List<Student> students, string identifier)
        {
            this.teachers = teachers;
            this.students = students;
            this.identifier = identifier;
            this.comment = string.Empty;
        }

        public Class(List<Teacher> teachers, List<Student> students, string identifier, string comment)
            : this(teachers, students, identifier)
        {
            this.comment = comment;
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
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
