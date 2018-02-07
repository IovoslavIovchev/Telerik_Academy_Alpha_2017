using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            if (category == null)
                { throw new ArgumentNullException(); }
            if (category.Length < 3 || category.Length > 10)
                { throw new ArgumentException("Category must be between 3 and 10 characters long!"); }

            this.category = category;
            this.Type = VehicleType.Motorcycle;
            this.Wheels = (int)this.Type;
        }

        public string Category => this.category;
    }
}
