using System;
using System.Collections.Generic;
using Agency.Core.Contracts;
using Agency.Models.Contracts;

namespace Agency.Commands.Creating
{
    public class CreateTicketCommand : CreateVehicleCommand
    {
        public CreateTicketCommand(IAgencyFactory factory, IEngine engine)
            : base(factory, engine)
        {
        }

        public override string Execute(IList<string> parameters)
        {
            IJourney journey;
            decimal administrativeCosts;

            try
            {
                journey = engine.Journeys[int.Parse(parameters[0])];
                administrativeCosts = decimal.Parse(parameters[1]);
            }
            catch
            {
                throw new ArgumentException("Failed to parse CreateTicket command parameters.");
            }

            var ticket = this.factory.CreateTicket(journey, administrativeCosts);
            this.engine.Tickets.Add(ticket);

            return $"Ticket with ID {engine.Tickets.Count - 1} was created.";
        }

    }
}
