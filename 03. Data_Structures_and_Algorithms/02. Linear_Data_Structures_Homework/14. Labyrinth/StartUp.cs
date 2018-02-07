using System;

namespace Labyrinth
{
    class StartUp
    {
        static string[,] labyrinth = new string[,]
        {
            {"0","0","0","x","0","x"},
            {"0","x","0","x","0","x" },
            {"0","*","x","0","x","0" },
            {"0","x","0","0","0","0" },
            {"0","0","0","x","x","0" },
            {"0","0","0","x","0","x" },
        };

        static bool[,] Visited = new bool[labyrinth.GetLength(0), labyrinth.GetLength(1)];

        static void Main()
        {
            //Start at position "*" ([2, 1] in our case)

            Traverse(2, 1);

            PrintMatrix();
        }

        static void PrintMatrix()
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j].Equals("0")) labyrinth[i, j] = "U";
                    Console.Write($"{labyrinth[i, j].PadLeft(2)} ");
                }
                Console.WriteLine();
            }
        }

        static void Traverse(int r, int c, int counter = 0)
        {
            if (!IsValid(r, c)) return;

            if (labyrinth[r, c].Equals("x")) return;

            if (!Visited[r,c])
            {
                Visited[r, c] = true;

                Traverse(r, c + 1, counter + 1);
                Traverse(r + 1, c, counter + 1);
                Traverse(r, c - 1, counter + 1);
                Traverse(r - 1, c, counter + 1);

                if (!labyrinth[r,c].Equals("*"))
                    labyrinth[r, c] = counter.ToString();
            }
        }

        static bool IsValid(int r, int c)
        {
            return r > -1 && c > -1 && r < labyrinth.GetLength(0) && c < labyrinth.GetLength(1);
        }
    }
}
