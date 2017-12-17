using System;
using Animal_Hierarchy.Models;
using Animal_Hierarchy.Contracts;
using Animal_Hierarchy.Common;
using System.Linq;

namespace Animal_Hierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[]
            {
                new Dog("go6o", 4, "male"),
                new Tomcat("bobi", 34),
                new Frog("prince", 12, "male"),
                new Dog("pe6o", 3, "male"),
                new Cat("kitty", 8, "female"),
                new Frog("ivanka", 39, "female"),
                new Kitten("dimitri4ka", 7)
            };

            Console.WriteLine($"Dogs Average Age: {AverageAge(AnimalType.Dog, animals):F2}");
            Console.WriteLine($"Cats Average Age: {AverageAge(AnimalType.Cat, animals):F2}");
            Console.WriteLine($"Frogs Average Age: {AverageAge(AnimalType.Frog, animals):F2}");
        }
        
        public static double AverageAge(AnimalType type, IAnimal[] animals)
        {
            double result = 0;
            foreach (var animal in animals.Where(x => x.Type == type))
            {
                result += animal.Age;
            }

            result /= animals.Where(x => x.Type == type).Count();

            return result;
        }
    }
}
