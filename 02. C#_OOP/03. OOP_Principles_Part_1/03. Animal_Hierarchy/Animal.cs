namespace Animal_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Bytes2you.Validation;

    class Animal
    {
        private int age;

        private string name;

        private string sex;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                Guard.WhenArgument(value, "Age").IsLessThan(0).Throw();
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Sex
        {
            get
            {
                return this.sex;
            }
            set
            {
                this.sex = value;
            }
        }
    }
}
