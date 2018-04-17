using System;
using System.Text;

namespace Passwords
{
    class StartUp
    {
        private static char[] Digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        private static int Count = 0;

        private static string Keystrokes;

        private static int K;

        private static void Recurse(StringBuilder result, int digitIndex, int keystrokeIndex = 0)
        {
            if (Count == -1)
            {
                return;
            }

            if (keystrokeIndex >= Keystrokes.Length)
            {
                Count++;

                if (Count == K)
                {
                    Console.WriteLine(result);
                    Count = -1;
                }

                return;
            }

            switch (Keystrokes[keystrokeIndex])
            {
                case '<':
                    for (int i = 0; i < digitIndex; i++)
                    {
                        result.Append(Digits[i]);
                        Recurse(result, i, keystrokeIndex + 1);
                        result.Remove(result.Length - 1, 1);
                    }
                    break;

                case '=':
                    result.Append(Digits[digitIndex]);
                    Recurse(result, digitIndex, keystrokeIndex + 1);
                    result.Remove(result.Length - 1, 1);
                    break;

                case '>':
                    if (digitIndex != 9)
                    {
                        result.Append("0");
                        Recurse(result, 9, keystrokeIndex + 1);
                        result.Remove(result.Length - 1, 1);
                    }
                    for (int i = digitIndex + 1; i < Digits.Length - 1; i++)
                    {
                        result.Append(Digits[i]);
                        Recurse(result, i, keystrokeIndex + 1);
                        result.Remove(result.Length - 1, 1);
                    }
                    break;
            }
        }
        
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            Keystrokes = Console.ReadLine();

            K = int.Parse(Console.ReadLine());

            for (int i = 0; i < Digits.Length; i++)
            {
                var result = new StringBuilder();

                result.Append(i);

                Recurse(result, Array.IndexOf(Digits, Char.Parse(i.ToString())));
            }
        }
    }
}