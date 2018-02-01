using System;
using System.Collections.Generic;
using System.Text;
using Animal_Hierarchy.Common;

namespace Animal_Hierarchy.Models
{
    public class Cat : Animal
    {
        public Cat(string name, uint age, string sex) 
            : base(AnimalType.Cat, name, age, sex, Sound.MyauMyau)
        {
            //CAT CONSTRUCTOR
        }
    }
}
