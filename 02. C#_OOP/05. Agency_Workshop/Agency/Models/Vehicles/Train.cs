using Agency.Models.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Models.Vehicles
{
    public class Train : Vehicle, ITrain
    {
        private int carts;

        public Train(int passengerCapacity, decimal pricePerKilometer, int carts) 
            : base(passengerCapacity, pricePerKilometer)
        {
            if (passengerCapacity < 30 || passengerCapacity > 150)
            {
                throw new ArgumentException("A train cannot have less than 30 passengers or more than 150 passengers.");
            }
            if (carts < 1 || carts > 15)
            {
                throw new ArgumentException("A train cannot have less than 1 cart or more than 15 carts.");
            }

            this.Type = VehicleType.Land;
            this.carts = carts;
        }

        public int Carts => this.carts;

        public override string ToString()
        {
            return $"Train ----\n{base.ToString()}\nCarts amount: {this.carts}";
        }
    }
}
