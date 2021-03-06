﻿using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Chair : Furniture, IChair
    {
        private readonly int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            Guard.WhenArgument(numberOfLegs, "Number of chair legs").IsLessThan(3).Throw();

            this.numberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs => this.numberOfLegs;

        public override string ToString()
        {
            return base.ToString() + $", Legs: {this.numberOfLegs}";
        }
    }
}
