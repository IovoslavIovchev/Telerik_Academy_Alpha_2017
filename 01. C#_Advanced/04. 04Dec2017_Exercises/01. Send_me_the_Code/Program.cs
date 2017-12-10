using System;
using System.Text;
using System.Numerics;

namespace Send_me_the_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            n = n.Replace("-", "");

            int sum = 0;

            for (int i = n.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(n[i].ToString());
                int index = n.Length - i;

                if (index % 2 == 1)
                    sum += (digit * index * index);
                else
                    sum += (digit * digit * index);
            }

            Console.WriteLine(sum);

            int d = sum % 10;
            if (d == 0)
            {
                Console.WriteLine("Big Vik wins again!");
            }
            else
            {
                Console.WriteLine(DecodeMessage(sum, d));
            }            
        }

        static string DecodeMessage(int sum, int d)
        {
            StringBuilder result = new StringBuilder();

            int rem = sum % 26;
            for (int i = 1; i <= d; i++)
            {
                int temp = 64 + rem + i;
                if (temp > 90)
                    temp -= 26;
                result.Append((char)(temp));
            }
            
            return result.ToString().Trim();
        }
    }
}
