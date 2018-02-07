using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models.Vehicles
{
    class Bus : Vehicle, IBus
    {
        public Bus(int passengerCapacity, decimal pricePerKilometer) 
            : base(passengerCapacity, pricePerKilometer)
        {
            if (passengerCapacity < 10 || passengerCapacity > 50)
            {
                throw new ArgumentException("A bus cannot have less than 10 passengers or more than 50 passengers.");
            }

            this.Type = VehicleType.Land;
        }

        public override string ToString()
        {
            return $"Bus ----\n{base.ToString()}";
        }
    }
}
