using System;
using System.Linq;
using System.Numerics;

namespace Move
{
    class Program
    {
        static long forwardsSum = 0;
        static long backwardsSum = 0;
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ');

                if (cmd[0].Equals("exit")) break;

                int times = int.Parse(cmd[0]), size = int.Parse(cmd[2]);

                switch (cmd[1])
                {
                    case "forward": //forwards* #grammarnazi
                        Forwards(ref position, times, size, array);
                        break;
                    case "backwards":
                        Backwards(ref position, times, size, array);
                        break;
                }
            }

            Console.WriteLine("Forward: {0}", forwardsSum);
            Console.WriteLine("Backwards: {0}", backwardsSum);
        }

        static void Forwards (ref int position, int times, int size, int[] array)
        {
            for (int i = 0; i < times; i++)
            {
                position += size;
                while (position >= array.Length) position -= array.Length;

                forwardsSum += array[position];
            }
        }
        static void Backwards (ref int position, int times, int size, int[] array)
        {
            for (int i = 0; i < times; i++) 
            {
                position -= size;
                while (position < 0) position = array.Length + position;

                backwardsSum += array[position];
            }
        }
    }
}
