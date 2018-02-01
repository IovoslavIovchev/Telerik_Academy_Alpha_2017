using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Player_Ranking
{
    class StartUp
    {
        static BigList<Player> players = new BigList<Player>();
        static Dictionary<string, Ordered<Player>> types = new Dictionary<string, BigList<Player>>();

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
                    case "find": Find(input[1]); break;
                    case "ranklist": Ranklist(int.Parse(input[1]), int.Parse(input[2])); break;
                }
            } while (true);
        }

        static void Add(string[] input)
        {
            string name = input[1], type = input[2];
            int age = int.Parse(input[3]), position = int.Parse(input[4]);

            Player temp = new Player { Name = name, Type = type, Age = age };
            players.Insert(position - 1, temp);
            if (!types.ContainsKey(type))
            {
                types.Add(type, new BigList<<Player>());
            }
            types[type].Add(temp);

            Console.WriteLine($"Added player {name} to position {position}");
        }

        static void Find(string type)
        {
            Console.Write($"Type {type}: ");
            if (types.ContainsKey(type))
            {
                Console.Write(string.Join("; ", types[type].OrderBy(x => x.Name).ThenByDescending(x => x.Age).Take(5)));
            }
            Console.WriteLine();
        }

        static void Ranklist(int start, int end)
        {
            for (int i = start - 1; i < end; i++)
            {
                Console.Write($"{i - start + 2}. {players[i]}{(i == end - start ? "" : "; ")}");
            }
            Console.WriteLine();
        }
    }

    class Player : IComparable<Player>
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }

        public int CompareTo(Player other)
        {
            return Age - other.Age;
        }

        public override string ToString()
        {
            return $"{Name}({Age})";
        }
    }
}
