using System;
using System.Collections.Generic;

namespace Path_Between_Two_Cells_in_a_Matrix
{
    class StartUp
    {
        static string[,] matrix = new string[,] //S is start point, E is end point, x is unpassable
        {
            { "S","x"," "," "," "},
            { " "," "," ","x"," "},
            { " ","x","x"," "," "},
            { " ","x","x"," ","x"},
            { "x","x","x"," ","E"}
        };

        static List<char> path;

        static List<string> result;

        static void Main()
        {
            path = new List<char>();
            result = new List<string>();

            Traverse(0, 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Traverse(int r, int c, char direction = 'N') // direction -> W, A, S, D
        {
            if (!IsValid(r, c)) return;

            if (matrix[r, c].Equals("E") && !direction.Equals('N'))
            {
                result.Add(string.Join(", ", path));
                return;
            }

            if (!direction.Equals('N'))
                path.Add(direction);

            Traverse(r - 1, c, 'W');
            Traverse(r, c - 1, 'A');
            Traverse(r + 1, c, 'S');
            Traverse(r, c + 1, 'D');
        }

        static bool IsValid(int r, int c)
        {
            return r > -1 && c > -1 && r < matrix.GetLength(0) && c < matrix.GetLength(1) && !matrix[r, c].Equals("x");
        }
    }
}
