using System;
using System.Collections.Generic;
using System.Text;
using Animal_Hierarchy.Common;

namespace Animal_Hierarchy.Models
{
    public class Dog : Animal
    {
        public Dog(string name, uint age, string sex)
            : base(AnimalType.Dog, name, age, sex, Sound.BauBau)
        {
            //DOG CONSTRUCTOR
        }
    }
}
