using System;
using System.Linq;

namespace Guards
{
    class StartUp
    {
        static int[,] maze;

        static bool gotOut;

        static int min;

        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            maze = new int[dimensions[0], dimensions[1]];
            gotOut = false;
            min = int.MaxValue;

            int guards = int.Parse(Console.ReadLine());
            for (int i = 0; i < guards; i++)
            {
                string[] temp = Console.ReadLine().Split();
                int r = int.Parse(temp[0]), c = int.Parse(temp[1]);
                maze[r, c] = -1;
                switch (temp[2])
                {
                    case "R": c += 1; break;
                    case "L": c -= 1; break;
                    case "U": r -= 1; break;
                    case "D": r += 1; break;
                }
                if (r < 0 || c < 0 || r >= maze.GetLength(0) || c >= maze.GetLength(1))
                {
                    continue;
                }
                maze[r, c] = 2;
            }

            Search(0, 0);

            if (!gotOut)
            {
                Console.WriteLine("Meow");
                return;
            }

            Console.WriteLine(min);
        }

        static void Search(int r, int c, int seconds = 1)
        {
            if (r >= maze.GetLength(0) || c >= maze.GetLength(1) || maze[r, c] == -1)
            {
                return;
            }
            if (r == maze.GetLength(0) - 1 && c == maze.GetLength(1) - 1)
            {
                gotOut = true;
                if (seconds < min)
                {
                    min = seconds;
                }

                return;
            }

            Search(r, c + 1, seconds + (maze[r, c] + 1));
            Search(r + 1, c, seconds + (maze[r, c] + 1));
        }
    }
}
