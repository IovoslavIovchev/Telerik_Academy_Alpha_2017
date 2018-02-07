using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Units_of_Work
{
    class StartUp
    {
        static Dictionary<string, SortedSet<Unit>> unitTypes;

        static Dictionary<string, Unit> unitNames;

        static SortedSet<Unit> units;

        static StringBuilder result;

        static void Main()
        {
            unitTypes = new Dictionary<string, SortedSet<Unit>>();
            unitNames = new Dictionary<string, Unit>();
            units = new SortedSet<Unit>();
            result = new StringBuilder();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                switch (commands[0])
                {
                    case "end": Console.WriteLine(result); return;
                    case "add": Add(commands[1], commands[2], int.Parse(commands[3])); break;
                    case "remove": Remove(commands[1]); break;
                    case "find": Find(commands[1]);  break;
                    case "power": Power(int.Parse(commands[1])); break;
                }
            }
        }

        static void Add(string name, string type, int attack)
        {
            if (unitNames.ContainsKey(name))
            {
                result.AppendLine($"FAIL: {name} already exists!");                
                return;
            }

            if (!unitTypes.ContainsKey(type)) unitTypes.Add(type, new SortedSet<Unit>());            

            Unit temp = new Unit(name, attack, type);
            unitTypes[type].Add(temp);
            unitNames.Add(name, temp);
            units.Add(temp);
            result.AppendLine($"SUCCESS: {name} added!");            
        }

        static void Remove(string name)
        {
            if (!unitNames.ContainsKey(name))
            {
                result.AppendLine($"FAIL: {name} could not be found!");                
                return;
            }

            Unit temp = unitNames[name];
            unitTypes[temp.Type].Remove(temp);
            units.Remove(temp);
            unitNames.Remove(name);

            result.AppendLine($"SUCCESS: {name} removed!");            
        }

        static void Find(string type)
        {
            result.AppendLine($"RESULT: {(unitTypes.ContainsKey(type) ? string.Join(", ", unitTypes[type].Take(10)) : "")}");            
        }

        static void Power(int number)
        {
            result.AppendLine($"RESULT: {string.Join(", ", units.Take(number))}");            
        }
    }

    struct Unit : IComparable<Unit>
    {
        public string Name { get; set; }

        public int Attack { get; set; }

        public string Type { get; set; }

        public Unit(string name, int attack, string type)
        {
            Name = name;
            Attack = attack;
            Type = type;
        }

        public int CompareTo(Unit other)
        {
            return other.Attack == Attack ? Name.CompareTo(other.Name) : other.Attack.CompareTo(Attack);
        }

        public override string ToString()
        {
            return $"{Name}[{Type}]({Attack})";
        }
    }
}
