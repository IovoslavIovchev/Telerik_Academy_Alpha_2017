using System;
using Wintellect.PowerCollections;

namespace Units_of_Work
{
    class StartUp
    {
        static OrderedMultiDictionary<string, Unit> units = new OrderedMultiDictionary<string, Unit>(false);

        static void Main()
        {
            string[] input;
            do
            {
                input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "end": return;
                    case "add": Add(input); break;
                }
            } while (true);
        }

        static void Add(string[] input)
        {
            string name = input[1], type = input[2];
            int attack = int.Parse(input[3]);

            if (!units.ContainsKey(type))
            {

            }
        }
    }

    class Unit
    {
        public string Name { get; set; }

        public int Attack { get; set; }
    }
}
