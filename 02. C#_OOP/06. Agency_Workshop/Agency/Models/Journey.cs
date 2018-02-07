using Agency.Models.Contracts;
using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models
{
    public class Journey : IJourney
    {
        private string destination;
        private int distance;
        private string startLocation;
        private IVehicle vehicle;

        public Journey(string startLocation, string destination, int distance, IVehicle vehicle)
        {
            if (startLocation.Length < 5 || startLocation.Length > 25)
            {
                throw new ArgumentException("The StartingLocation's length cannot be less than 5 or more than 25 symbols long.");
            }
            if (destination.Length < 5 || destination.Length > 25)
            {
                throw new ArgumentException("The Destination's length cannot be less than 5 or more than 25 symbols long.");
            }
            if (distance < 5 || distance > 5000)
            {
                throw new ArgumentException("The Distance cannot be less than 5 or more than 5000 kilometers.");
            }

            this.startLocation = startLocation;
            this.destination = destination;
            this.distance = distance;
            this.vehicle = vehicle;
        }

        public string Destination => this.destination;

        public int Distance => this.distance;

        public string StartLocation => this.startLocation;

        public IVehicle Vehicle => this.vehicle;

        public decimal CalculateTravelCosts()
        {
            return this.distance * this.vehicle.PricePerKilometer;
        }

        public override string ToString()
        {
            return $"Journey ----\nStart location: {this.startLocation}\nDestination: {this.destination}\nDistance: {this.distance}\nVehicle type: {this.vehicle.Type}\nTravel costs: {this.CalculateTravelCosts()}";
        }
    }
}
