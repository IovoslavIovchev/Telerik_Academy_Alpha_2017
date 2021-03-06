﻿using System.Collections.Generic;
using OlympicGames.Core.Contracts;
using OlympicGames.Olympics.Contracts;

namespace OlympicGames.Core.Commands
{
    public class CreateSprinterCommand : CreateOlympianCommand, ICommand
    {
        private readonly IDictionary<string, double> records;

        public CreateSprinterCommand(IOlympicCommittee committee, IOlympicsFactory factory, IList<string> commandLine)
            : base(committee, factory, commandLine)
        {
            this.records = new Dictionary<string, double>();

            foreach (var recordItem in this.CommandParameters)
            {
                var recordValue = recordItem.Split('/');
                this.records.Add(recordValue[0], double.Parse(recordValue[1]));
            }
        }

        protected override IOlympian CreatePerson()
        {
            return this.Factory.CreateSprinter(this.FirstName, this.LastName, this.Country, this.records);
        }
    }
}
