using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Hierarchy.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, uint age) 
            : base(name, age, "Male")
        {
            //TOMCAT CONSTRUCTOR
        }
    }
}
