using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agency.Models.Vehicles.Contracts;

namespace Agency.Models.Vehicles
{
    public class Airplane : Vehicle, IAirplane
    {
        private bool hasFreeFood;

        public Airplane(int passengerCapacity, decimal pricePerKilometer, bool hasFreeFood) 
            : base(passengerCapacity, pricePerKilometer)
        {
            this.Type = VehicleType.Air;
            this.hasFreeFood = hasFreeFood;
        }

        public bool HasFreeFood => this.hasFreeFood;

        public override string ToString()
        {
            return $"Airplane ----\n{base.ToString()}\nHas free food: {this.hasFreeFood}";
        }
    }
}
