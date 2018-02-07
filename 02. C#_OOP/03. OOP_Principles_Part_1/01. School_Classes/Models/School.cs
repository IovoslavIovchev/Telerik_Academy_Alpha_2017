using System;
using System.Collections.Generic;
using System.Text;

namespace School_Classes.Models
{
    class School
    {
        private List<Class> classes;

        public School(List<Class> classes)
        {
            this.classes = classes;
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
        }

    }
}
