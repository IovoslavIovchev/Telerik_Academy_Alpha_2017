namespace Classes_Part_1
{
    using System;
    using System.ComponentModel;

    class StartUp
    {
        static void Main(string[] args)
        {
            var a = new GSM("Galaxy", "Samsung");

            Console.WriteLine(a.ToString());
        }
    }
}
