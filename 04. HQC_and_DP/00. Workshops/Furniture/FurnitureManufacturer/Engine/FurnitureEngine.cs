using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureManufacturer.Engine
{
    public sealed class FurnitureEngine : IEngine
    {
        private readonly ICommandParser parser;
        private readonly IRenderer renderer;

        public FurnitureEngine(
            ICommandParser parser,
            IRenderer renderer
        )
        {
            this.parser = parser;
            this.renderer = renderer;
        }

        public void Start()
        {
            List<string> result = new List<string>();

            string input;

            while (!String.IsNullOrEmpty(input = this.renderer.Input()))
            {
                try
                {
                    string output = ProcessCommand(input);

                    result.Add(output);
                }
                catch (Exception e)
                {
                    result.Add(e.Message);
                }
            }

            this.renderer.Output(result);
        }

        private string ProcessCommand(string input)
        {
            List<string> args = input.Split(' ').ToList();

            string commandName = args[0];
            List<string> commandArgs = args.Skip(1).ToList();

            ICommand command = this.parser.ParseCommand(commandName.ToLower());

            return command.Execute(commandArgs);
        }
    }
}
