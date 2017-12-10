using System;
using System.Linq;

namespace Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int R = int.Parse(size[0]), C = int.Parse(size[1]);

            int[,] P1 = new int[R, C], P2 = new int[R, C];
            int oneScore = 0, twoScore = 0;

            FillMatrixOne(P1, R, C, ref oneScore); FillMatrixTwo(P2, R, C, ref twoScore);  

            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ');
                if (cmd[0].Equals("END")) break;

                int x = int.Parse(cmd[1]), y = int.Parse(cmd[2]);
                switch (cmd[0])
                {
                    case "P1":
                        Attack(P2, x, y, ref twoScore);
                        break;
                    case "P2":
                        Attack(P1, x, y, ref oneScore);
                        break;
                }
            }        

            Console.WriteLine("{0}:{1}", oneScore, twoScore); 
        }

        static void Attack(int[,] attacked, int x, int y, ref int score)
        {
                if (attacked[x, y] == 1)
                {
                    Console.WriteLine("Booom");
                    attacked[x, y] = -1;
                    score--;
                }
                else if (attacked[x, y] == 0)
                {
                    Console.WriteLine("Missed");
                    attacked[x, y] = -1;
                }
                else if (attacked[x, y] == -1)
                    Console.WriteLine("Try again!");
            
        }

        static void FillMatrixOne(int[,] m, int R, int C, ref int score)
        {
            for (int i = 0; i < R; i++)
            {
                int[] temp = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < C; j++)
                {
                    m[i, j] = temp[j];
                    score += temp[j];
                }
            }
        }
        static void FillMatrixTwo(int[,] m, int R, int C, ref int score)
        {
            for (int i = R - 1; i >= 0; i--)
            {
                int[] temp = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < C; j++)
                {
                    m[i, j] = temp[j];
                    score += temp[j];
                }
            }
        }
    }
}
