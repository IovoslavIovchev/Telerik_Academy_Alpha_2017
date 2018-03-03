using OlympicGames.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicGames.Core.Providers.Decorators
{
    public class CommandProcessorDecorator : ICommandProcessor
    {
        private ICommandProcessor cmdProcessor;

        public CommandProcessorDecorator(ICommandProcessor cmdProcessor)
        {
            this.cmdProcessor = cmdProcessor;
        }

        public ICollection<ICommand> Commands => cmdProcessor.Commands;

        public void Add(ICommand command)
        {
            cmdProcessor.Add(command);
        }

        public void ProcessCommands()
        {
            cmdProcessor.ProcessCommands();
        }

        public void ProcessSingleCommand(ICommand command)
        {
            cmdProcessor.ProcessSingleCommand(command);

            Console.WriteLine($"-- [{DateTime.Now.ToString()}] Processed Command --");
        }
    }
}
