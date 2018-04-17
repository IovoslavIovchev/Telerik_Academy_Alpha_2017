using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Supermarket_Queue
{
    class StartUp
    {
        private static BigList<string> queue;

        private static Dictionary<string, int> names;

        private static string Append(string name)
        {
            queue.Add(name);

            if (!names.ContainsKey(name))
            {
                names.Add(name, 0);
            }
            names[name]++;

            return "OK";
        }

        private static string Insert(int position, string name)
        {
            if (position < 0 || position > queue.Count)
            {
                return "Error";
            }

            queue.Insert(position, name);

            if (!names.ContainsKey(name))
            {
                names.Add(name, 0);
            }
            names[name]++;

            return "OK";
        }

        private static string Find(string name)
        {
            if (!names.ContainsKey(name))
            {
                return "0";
            }

            return names[name].ToString();
        }

        private static string Serve(ushort count)
        {
            if (count > queue.Count)
            {
                return "Error";
            }

            string served = string.Join(" ", queue.Range(0, count));

            for (int i = 0; i < count; i++)
            {
                if (names.ContainsKey(queue[i]))
                {
                    names[queue[i]]--;
                }
            }

            queue.RemoveRange(0, count);

            return served;
        }

        private static void ExecuteCommands()
        {
            StringBuilder builder = new StringBuilder();

            while (true)
            {
                string[] parameters = Console.ReadLine().Split();

                switch (parameters[0])
                {
                    case "Append":
                        builder.AppendLine(Append(parameters[1]));
                        break;
                    case "Insert":
                        builder.AppendLine(Insert(int.Parse(parameters[1]), parameters[2]));
                        break;
                    case "Find":
                        builder.AppendLine(Find(parameters[1]));
                        break;
                    case "Serve":
                        builder.AppendLine(Serve(ushort.Parse(parameters[1])));
                        break;
                    case "End":
                        PrintResult(builder.ToString());
                        return;
                }
            }

        }

        private static void PrintResult(string result)
        {
            Console.Write(result);
        }

        static void Main()
        {
            queue = new BigList<string>();

            names = new Dictionary<string, int>();

            ExecuteCommands();
        }
    }
}
