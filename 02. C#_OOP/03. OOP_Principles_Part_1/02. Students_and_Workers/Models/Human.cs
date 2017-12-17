using System;
using System.Collections.Generic;
using System.Text;

namespace Students_and_Workers.Models
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public new virtual string Info()
        {
            return $"{this.firstName} {this.LastName}";
        }
    }
}
