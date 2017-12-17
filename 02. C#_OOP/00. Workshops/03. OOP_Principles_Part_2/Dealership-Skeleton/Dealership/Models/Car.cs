using System;
using System.Collections.Generic;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats) 
            : base(make, model, price)
        {
            if (seats < 1 || seats > 10)
                { throw new ArgumentException("Seats must be between 1 and 10!"); }

            this.seats = seats;
            this.Type = VehicleType.Car;
            this.Wheels = (int)this.Type;
        }

        public int Seats => this.seats;
    }
}
