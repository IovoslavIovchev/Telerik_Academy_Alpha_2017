using Bytes2you.Validation;
using Cosmetics.Common;
using System;

namespace Cosmetics.Products
{
    public class Product
    {
        private readonly decimal price;
        private readonly string name;
        private readonly string brand;
        private readonly GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(name.Length, "Product Name Length").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand.Length, "Brand Name Length").IsLessThan(2).IsGreaterThan(10).Throw();
            Guard.WhenArgument(price, "Product price").IsLessThan(0).Throw();

            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
        }

        public string Name { get { return this.name; } }
        public string Brand { get { return this.brand; } }
        public decimal Price { get { return this.price; } }
        public GenderType Gender { get { return this.gender; } }

        public string Print()
        {
            return $" #{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n ===";
        }
    }
}
