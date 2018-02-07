using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Engine
{
    public class ConsoleRenderer : IRenderer
    {
        public string Input()
        {
            return Console.ReadLine();
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        public void Output(IEnumerable<string> output)
        {
            var result = new StringBuilder();
            foreach (var line in output)
            {
                result.AppendLine(line);
            }

            Console.Write(result.ToString());
        }
    }
}
