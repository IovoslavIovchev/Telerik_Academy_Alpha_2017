using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace Cosmetics.Products
{
    public class Toothpaste : IToothpaste
    {
        private string name;

        private string brand;

        private decimal price;

        private GenderType gender;

        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
        {
            Guard.WhenArgument(name, "Name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "Name").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand, "Brand").IsNull().Throw();
            Guard.WhenArgument(brand.Length, "Brand").IsLessThan(2).IsGreaterThan(10).Throw();
            Guard.WhenArgument(price, "Price").IsLessThan(0).Throw();
            Guard.WhenArgument(ingredients, "Ingredients").IsNull().Throw();

            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
            this.ingredients = ingredients;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
        }

        public string Ingredients
        {
            get
            {
                return this.ingredients;
            }
        }

        public string Print()
        {
            return $"#{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n #Ingredients: {this.ingredients}\r\n===";
        }
    }
}