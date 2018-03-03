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
        private readonly IDatabase database;

        public FurnitureEngine(
            ICommandParser parser,
            IRenderer renderer,
            IDatabase database
        )
        {
            this.parser = parser;
            this.renderer = renderer;
            this.database = database;
        }

        public void Start()
        {
            string input;

            while (!String.IsNullOrEmpty(input = this.renderer.Input()))
            {
                try
                {
                    ProcessCommand(input);
                }
                catch (Exception e)
                {
                    this.database.Log(e.Message);
                }
            }

            this.renderer.Output(this.database.TextLog);
        }

        private void ProcessCommand(string input)
        {
            List<string> args = input.Split(' ').ToList();

            string commandName = args[0];
            List<string> commandArgs = args.Skip(1).ToList();

            ICommand command = this.parser.ParseCommand(commandName.ToLower());

            command.Execute(commandArgs);
        }
    }
}
