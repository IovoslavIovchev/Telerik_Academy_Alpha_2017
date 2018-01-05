using Agency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models
{
    public class Ticket : ITicket
    {
        private decimal administrativeCosts;
        private IJourney journey;

        public Ticket(IJourney journey, decimal administrativeCosts)
        {
            this.administrativeCosts = administrativeCosts;

            this.journey = journey ?? throw new ArgumentNullException("Journey can't be null");
        }

        public decimal AdministrativeCosts => this.administrativeCosts;

        public IJourney Journey => this.journey;

        public decimal CalculatePrice()
        {
            return this.administrativeCosts + this.journey.CalculateTravelCosts();
        }

        public override string ToString()
        {
            return $"Ticket ----\nDestination: {this.journey.Destination}\nPrice: {this.CalculatePrice()}";
        }
    }
}
