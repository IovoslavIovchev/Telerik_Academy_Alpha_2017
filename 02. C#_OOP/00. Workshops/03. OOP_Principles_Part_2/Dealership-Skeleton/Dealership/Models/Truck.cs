using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            if (weightCapacity < 1 || weightCapacity > 10)
                { throw new ArgumentException("Weight capacity must be between 1 and 100!"); }

            this.weightCapacity = weightCapacity;
            this.Type = VehicleType.Truck;
            this.Wheels = (int)this.Type;
        }

        public int WeightCapacity => this.weightCapacity;
    }    
}
