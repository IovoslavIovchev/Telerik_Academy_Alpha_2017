using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System;

namespace Cosmetics.Products
{
    public class Shampoo : IShampoo
    {
        private string name;

        private string brand;

        private decimal price;

        private GenderType gender;

        private uint milliliters;

        private UsageType usageType;

        public Shampoo(string name, string brand, decimal price, 
                       GenderType gender, uint milliliters, UsageType usageType)
        {
            Guard.WhenArgument(name, "Name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "Name").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(brand, "Brand").IsNull().Throw();
            Guard.WhenArgument(brand.Length, "Brand").IsLessThan(2).IsGreaterThan(10).Throw();            
            Guard.WhenArgument(price, "Price").IsLessThan(0).Throw();

            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
            this.milliliters = milliliters;
            this.usageType = usageType;
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

        public uint Milliliters
        {
            get
            {
                return this.milliliters;
            }
        }

        public UsageType UsageType
        {
            get
            {
                return this.usageType;
            }
        }

        public string Print()
        {
            return $"#{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n #Milliliters: {this.milliliters}\r\n #UsageType: {this.usageType}\r\n===";
        }
    }
}
