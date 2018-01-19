using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Player_Ranking
{
    class StartUp
    {
        static BigList<Player> players;

        static Dictionary<string, OrderedSet<Player>> playersByType;

        static StringBuilder result;

        static void Main()
        {
            players = new BigList<Player>();
            playersByType = new Dictionary<string, OrderedSet<Player>>();
            result = new StringBuilder();

            string input;
            while (!(input = Console.ReadLine()).Equals("end"))
            {
                string[] commands = input.Split();
                switch (commands[0])
                {
                    case "add":
                        AddPlayer(commands[1], int.Parse(commands[3]), commands[2], int.Parse(commands[4]));
                        break;
                    case "find":
                        Find(commands[1]);
                        break;
                    case "ranklist":
                        Ranklist(int.Parse(commands[1]) - 1, int.Parse(commands[2]) - 1);
                        break;
                }
            }

            Console.WriteLine(result);
        }

        private static void AddPlayer(string name, int age, string type, int position)
        {
            Player temp = new Player(name, age);

            players.Insert(position - 1, temp);

            if (!playersByType.ContainsKey(type)) playersByType.Add(type, new OrderedSet<Player>());

            if (playersByType[type].Count == 5)
            {
                Player last = playersByType[type][4];

                if (last.CompareTo(temp) > 0)
                {
                    playersByType[type].RemoveLast();
                    playersByType[type].Add(temp);
                }
            }
            else
            {
                playersByType[type].Add(temp);
            }


            result.AppendFormat($"Added player {name} to position {position}");
            result.AppendLine();
        }

        private static void Find(string type)
        {
            if (playersByType.ContainsKey(type) && playersByType[type].Count > 0)
            {
                result.Append($"Type {type}:");
                foreach (var player in playersByType[type])
                {
                    result.AppendFormat($" {player};");
                }
                result.Remove(result.Length - 1, 1);
            }
            else
            {
                result.Append($"Type {type}: ");
            }

            result.AppendLine();
        }

        private static void Ranklist(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                result.AppendFormat($"{i + 1}. {players[i]}; ");
            }
            result.Remove(result.Length - 2, 2);
            result.AppendLine();
        }
    }

    struct Player : IComparable<Player>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Player(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Player other)
        {
            return this.Name.CompareTo(other.Name) == 0 ? this.Age.CompareTo(other.Age) * -1 : this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name}({Age})";
        }
    }
}