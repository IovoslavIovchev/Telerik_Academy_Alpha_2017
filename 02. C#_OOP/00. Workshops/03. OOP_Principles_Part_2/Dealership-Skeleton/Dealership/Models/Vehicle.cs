using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Vehicle : IVehicle
    {
        private readonly string make;
        private readonly string model;
        private readonly decimal price;
        private VehicleType type;
        private int wheels;
        private IList<IComment> comments;

        public Vehicle(string make, string model, decimal price)
        {
            if (make == null || model == null) { throw new ArgumentNullException(); }
            if (make.Length < 2 || make.Length > 15)
                { throw new ArgumentException("Make must be between 2 and 15 characters long!"); }
            if (model.Length < 2 || model.Length > 15)
                { throw new ArgumentException("Model must be between 2 and 15 characters long!"); }
            if (price < 0 || price > 1000000)
                { throw new ArgumentException("Price must be between 0.0 and 1000000.0!"); }

            this.make = make;
            this.model = model;
            this.price = price;
            this.comments = new List<IComment>();
        }

        public string Make => this.make;

        public string Model => this.model;

        public decimal Price => this.price;

        public int Wheels
        {
            get { return this.wheels; }
            protected set { this.wheels = value; }
        }

        public VehicleType Type
        {
            get { return this.type; }
            protected set { this.type = value; }
        }

        public IList<IComment> Comments => this.comments;
    }
}
