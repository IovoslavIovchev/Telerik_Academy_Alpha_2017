using System;
using System.Collections.Generic;
using System.Text;

namespace School_Classes.Models
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();
        private string comment;

        public Teacher(string firstName, string lastName, List<Discipline> disciplines) 
            : base(firstName, lastName)
        {
            this.disciplines = disciplines;
            this.comment = string.Empty;
        }

        public Teacher(string firstName, string lastName, List<Discipline> disciplines, string comment)
            : this(firstName, lastName, disciplines)
        {
            this.comment = comment;
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
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
