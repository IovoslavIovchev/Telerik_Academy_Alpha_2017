using System;

namespace English_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()) % 10;

            Console.WriteLine(DigitAsWord(number));
        }

        static string DigitAsWord(int n)
        {
            string[] words = {"zero", "one", "two", "three", "four", 
                              "five", "six", "seven", "eight", "nine"};

            return words[n];
        }
    }
}
