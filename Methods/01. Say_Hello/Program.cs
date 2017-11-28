using System;

namespace Say_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello(Console.ReadLine());
        }

        static void SayHello (string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
