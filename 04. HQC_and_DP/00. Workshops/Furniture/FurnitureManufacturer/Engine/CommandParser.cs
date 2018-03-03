using Autofac;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System;

namespace FurnitureManufacturer.Engine
{
    public class CommandParser : ICommandParser
    {
        private readonly IComponentContext container;
        private readonly Constants constants;

        public CommandParser(IComponentContext container, Constants constants)
        {
            this.container = container;
            this.constants = constants;
        }

        public ICommand ParseCommand(string commandName)
        {
            try
            {
                return this.container.ResolveNamed<ICommand>(commandName);
            }
            catch
            {
                throw new ArgumentException(string.Format(this.constants.InvalidCommandErrorMessage, commandName));
            }
        }
    }
}
