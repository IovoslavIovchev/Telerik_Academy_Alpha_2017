using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Hierarchy.Models
{
    public class Kitten : Cat
    {
        public Kitten(string name, uint age) 
            : base(name, age, "Female")
        {
            //KITTEN CONSTRUCTOR
        }
    }
}
