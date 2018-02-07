using System;
using System.Collections.Generic;
using System.Text;
using Animal_Hierarchy.Contracts;
using Animal_Hierarchy.Common;

namespace Animal_Hierarchy.Models
{
    public class Animal : IAnimal, ISound
    {
        private AnimalType type;
        private string name;
        private uint age;
        private Sex sex;
        private Sound sound;

        public Animal(AnimalType type, string name, uint age, string sex, Sound sound)
        {
            this.type = type;
            this.name = name;
            this.age = age;
            this.sex = (Sex)Enum.Parse(typeof(Sex), sex, true);
            this.sound = sound;
        }

        public AnimalType Type => this.type;

        public string Name => this.name;

        public uint Age => this.age;

        public Sex Sex => this.sex;

        public void MakeSound()
        {
            Console.WriteLine($"The {this.type} {this.name} makes {this.sound}");
        }
    }
}
