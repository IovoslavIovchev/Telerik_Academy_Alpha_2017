using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Secret_Message
{
    class StartUp
    {
        static void Main()
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            int start = message.LastIndexOf('{') + 1;
            int length = message.IndexOf('}', start) - start;

            while (start != 0)
            {
                string tempString = message.Substring(start, length);

                int l = 0;
                for (int i = start - 2; i >= 0; i--)
                {
                    if (Char.IsDigit(message[i]))
                    {
                        l++;
                    }
                    else
                    {
                        break;
                    }
                }

                int count = int.Parse(message.Substring(start - 1 - l, l));

                sb.Clear();
                for (int i = 0; i < count; i++)
                {
                    sb.Append(tempString);
                }

                message = message.Replace($"{count}{{{tempString}}}", sb.ToString());
               

                start = message.LastIndexOf('{') + 1;
                length = message.IndexOf('}', start) - start;
            }

            Console.WriteLine(message);
        }
    }
}