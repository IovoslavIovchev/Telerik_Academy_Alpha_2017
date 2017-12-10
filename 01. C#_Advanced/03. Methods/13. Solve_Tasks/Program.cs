using System;
using System.Linq;

namespace Solve_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1. Reverse the digits of a number");
                Console.WriteLine(" 2. Calculate the average of an Integer sequence");
                Console.WriteLine(" 3. Solve a linear equation");
                Console.WriteLine(" 0. Exit the program");

                Console.Write(Environment.NewLine + "Your choice: ");
                byte choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: return;
                    case 1: ReverseDigits("Enter a number: "); break;
                    case 2: CalculateAverage("Enter a range of numbers, separated by a space: "); break;
                    case 3: SolveEquation("Enter [a] and [b] for the equation [a * x + b = 0], separated by a space: "); break;
                    default: Console.WriteLine("Invalid choice!"); break;

                }
                Console.WriteLine();
            }
        }

        static void ReverseDigits(string msg)
        {
            Console.Write(msg);
            decimal num = decimal.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Only non-negative numbers can be reversed. ");
                ReverseDigits("Please enter a new number: ");
            }

            char[] temp = num.ToString().ToCharArray().Reverse().ToArray();

            Console.WriteLine(Environment.NewLine + "Reversed number is: " + string.Join("", temp));
        }

        static void CalculateAverage(string msg)
        {
            Console.Write(msg);
            try
            {
                long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

                Console.WriteLine(Environment.NewLine + "The average of the sequence is: " + numbers.Average());
            }
            catch (System.Exception)
            {
                Console.Write("Please try again. ");
                CalculateAverage(msg);
            }
        }

        static void SolveEquation(string msg)
        {
            try
            {
                Console.Write(msg);
                long[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

                decimal x = -numbers[1] / numbers[0];

                Console.WriteLine(Environment.NewLine + "[x] = " + x);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("[a] can't be equal to 0. ");
                SolveEquation(msg);
            }            
        }
    }
}
