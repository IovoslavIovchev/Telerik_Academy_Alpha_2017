using System;
using System.Collections.Generic;
using System.Text;
using Animal_Hierarchy.Common;

namespace Animal_Hierarchy.Models
{
    public class Frog : Animal
    {
        public Frog(string name, uint age, string sex) 
            : base(AnimalType.Frog, name, age, sex, Sound.CroakCroak)
        {
            //FROG CONSTRUCOR
        }
    }
}
