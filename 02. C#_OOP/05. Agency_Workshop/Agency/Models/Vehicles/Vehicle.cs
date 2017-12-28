using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models.Vehicles
{
    public class Vehicle : IVehicle
    {
        private int passengerCapacity;
        private decimal pricePerKilometer;
        private VehicleType type;

        public Vehicle(int passengerCapacity, decimal pricePerKilometer)
        {
            if (passengerCapacity < 1 || passengerCapacity > 800)
            {
                throw new ArgumentException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
            }
            if (pricePerKilometer < 0.1M || pricePerKilometer > 2.5M)
            {
                throw new ArgumentException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
            }

            this.passengerCapacity = passengerCapacity;
            this.pricePerKilometer = pricePerKilometer;
        }

        public int PassangerCapacity => this.passengerCapacity;

        public decimal PricePerKilometer => this.pricePerKilometer;

        public VehicleType Type { get => this.type; protected set => this.type = value; }

        public override string ToString()
        {
            return $"Passenger capacity: {this.passengerCapacity}\nPrice per kilometer: {this.pricePerKilometer}\nVehicle type: {this.type}";
        }
    }
}
