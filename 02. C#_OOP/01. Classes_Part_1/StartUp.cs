namespace Classes_Part_1
{
    using System;
    using System.ComponentModel;

    class StartUp
    {
        static void Main(string[] args)
        {
            var a = new GSM("Galaxy", "Samsung");

            Console.WriteLine(a.Model);
            Console.WriteLine(a.Manufacturer);
            Console.WriteLine(a.Price);
            Console.WriteLine(a.Owner);
            Console.WriteLine(a.BatteryHoursIdle);
            Console.WriteLine(a.BatteryHoursTalk);
            Console.WriteLine(a.DisplaySize);
            Console.WriteLine(a.DisplayNumberOfColours);
            Console.WriteLine(a.BatteryType.ToString());
        }
    }
}
