using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Messages_in_Bottle
{
    class StartUp
    {
        static Dictionary<string, char> codes;

        static List<string> result;

        static void Main()
        {
            string digits = Console.ReadLine();
            string message = Console.ReadLine();

            CodesToDictionary(message);
            result = new List<string>();

            DecodeMessages(digits, string.Empty);

            Console.WriteLine(result.Count());
            foreach (var msg in result.OrderBy(x => x))
            {
                Console.WriteLine(msg);
            }
        }

        static void CodesToDictionary(string message)
        {
            codes = new Dictionary<string, char>();
            int start = 0, length = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsLetter(message[i]) && i != 0)
                {
                    codes.Add(message.Substring(start + 1, length - 1), message[start]);
                    length = 1;
                    start = i;
                }
                else
                {
                    length++;
                }
            }
            codes.Add(message.Substring(start + 1, length - 1), message[start]);
        }

        private static void DecodeMessages(string messages, string preceding)
        {
            if (messages == string.Empty)
            {
                return;
            }
        
            for (int i = 1; i <= messages.Length; i++)
            {
                string current = messages.Substring(0, i);
                string next = messages.Substring(i);
        
                if (!codes.ContainsKey(current))
                {
                    continue;
                }
        
                char letter = codes[current];
                if (next != string.Empty)
                {
                    DecodeMessages(next, string.Concat(preceding, letter));
                }
                else
                {
                    result.Add(string.Concat(preceding, letter));
                }
            }
        }
    }
}
