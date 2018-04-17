using System;
using System.Collections.Generic;
using System.Linq;

namespace Portals
{
    class StartUp
    {
        private static int[,] labyrinth;

        private static bool[,] visited;

        private static Stack<int> stack;

        private static int max;

        private static void InitializeMatrix()
        {
            max = 0;
            stack = new Stack<int>();

            int[] matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            labyrinth = new int[matrixSize[0], matrixSize[1]];
            visited = new bool[matrixSize[0], matrixSize[1]];

            for (int i = 0; i < matrixSize[0]; i++)
            {
                string[] nums = Console.ReadLine().Split();

                for (int j = 0; j < matrixSize[1]; j++)
                {
                    if (!int.TryParse(nums[j], out labyrinth[i, j]))
                    {
                        labyrinth[i, j] = -1;
                    }
                }
            }
        }

        private static bool IsValid(int r, int c)
        {
            return r > -1 && c > -1 && r < labyrinth.GetLength(0) && c < labyrinth.GetLength(1) && labyrinth[r, c] != -1;
        }

        private static void Recursion(int r, int c)
        {
            if (visited[r, c])
            {
                return;
            }

            int power = labyrinth[r, c];

            if (!(IsValid(r - power, c) || IsValid(r + power, c) ||
                  IsValid(r, c - power) || IsValid(r, c + power))) return;

            stack.Push(power);
            visited[r, c] = true;

            if (IsValid(r - power, c)) Recursion(r - power, c);
            if (IsValid(r + power, c)) Recursion(r + power, c);
            if (IsValid(r, c - power)) Recursion(r, c - power);
            if (IsValid(r, c + power)) Recursion(r, c + power);

            visited[r, c] = false;

            int sum = stack.Sum();
            max = max > sum ? max : sum;
            stack.Pop();
        }

        static void Main()
        {
            int[] startPosition = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            InitializeMatrix();

            int startR = startPosition[0],
                startC = startPosition[1];

            Recursion(startR, startC);

            Console.WriteLine(max);
        }
    }
}
