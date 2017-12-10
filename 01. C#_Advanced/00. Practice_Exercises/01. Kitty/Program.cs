using System;
using System.Linq;
using System.Collections.Generic;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> inventory = new Dictionary<char, int>() { { '@', 0 }, { '*', 0 }, { 'x', 0 } };

            char[] field = Console.ReadLine().ToCharArray();
            int[] movement = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int p = 0; //p for position
            for (int i = 0; i <= movement.Length; i++)
            {
                while (p < 0)
                    p = field.Length + p;
                while (p >= field.Length)
                    p -= field.Length;

                char item = field[p];

                if (!item.Equals('-') && !item.Equals('x')) //IS NOT EMPTY AND IS NOT A DEADLOCK
                {
                    inventory[item]++;

                    field[p] = '-';
                }

                if (item.Equals('x')) //IS A DEADLOCK
                {
                    if (p % 2 == 0)
                    {
                        if (inventory['@'] == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", i);
                            return;
                        }

                        field[p] = '@';
                        inventory['@']--;
                    }
                    else
                    {
                        if (inventory['*'] == 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", i);
                            return;
                        }

                        field[p] = '*';
                        inventory['*']--;
                    }

                    inventory['x']++;
                }

                if (i != movement.Length)
                    p += movement[i];
            }

            Console.WriteLine("Coder souls collected: {0}", inventory['@']);
            Console.WriteLine("Food collected: {0}", inventory['*']);
            Console.WriteLine("Deadlocks: {0}", inventory['x']);
        }
    }
}
