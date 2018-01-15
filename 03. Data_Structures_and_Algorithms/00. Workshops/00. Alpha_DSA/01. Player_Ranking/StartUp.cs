using System;
using System.Collections.Generic;
using System.Linq;

namespace Player_Ranking
{
    class StartUp
    {
        static List<Player> players = new List<Player>();

        static void Main()
        {
            string[] input;
            do
            {
                input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "add": AddPlayer(input);
                        break;
                    case "find": FindPlayers(input);
                        break;
                    case "ranklist": Ranklist(input);
                        break;
                }
            } while (!input[0].Equals("end"));
        }

        static void AddPlayer(string[] input)
        {
            string name = input[1], type = input[2];
            int age = int.Parse(input[3]), position = int.Parse(input[4]);
            players.Insert(position - 1, new Player { Name = name, Type = type, Age = age });

            Console.WriteLine($"Added player {name} to position {position}");
        }

        static void FindPlayers(string[] input)
        {
            string type = input[1];

            Console.WriteLine($"Type {type}: {string.Join("; ", players.Where(x => x.Type == type).OrderBy(x => x.Name).ThenByDescending(x => x.Age).Take(5))}");
        }

        static void Ranklist(string[] input)
        {
            int start = int.Parse(input[1]) - 1, end = int.Parse(input[2]) - 1;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i + 1}. {players[i]}{(i == end ? "" : "; ")}");
            }
            Console.WriteLine();
        }
    }

    class Player
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name}({Age})";
        }
    }
}
