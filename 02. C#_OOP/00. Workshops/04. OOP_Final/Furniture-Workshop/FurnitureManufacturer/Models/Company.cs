using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private readonly string name;
        private readonly string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            Guard.WhenArgument(name, "Company Name").IsNull().Throw();
            Guard.WhenArgument(name, "Company Name").IsEmpty().Throw();
            Guard.WhenArgument(name.Length, "Company Name length").IsLessThan(5).Throw();
            Guard.WhenArgument(registrationNumber, "Company registration number").IsNull().Throw();
            Guard.WhenArgument(registrationNumber.Length, "Company registration number").IsNotEqual(10).Throw();
            if (registrationNumber.Any(x => !Char.IsDigit(x))) { throw new ArgumentException("Company registration number must have only digits."); }

            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name => this.name;

        public string RegistrationNumber => this.registrationNumber;

        public ICollection<IFurniture> Furnitures => new List<IFurniture>(this.furnitures);

        public void Add(IFurniture furniture)
        {
            Guard.WhenArgument(furniture, "Furniture").IsNull().Throw();

            this.furnitures.Add(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x => x.Model == model);
        }

        public void Remove(IFurniture furniture)
        {
            Guard.WhenArgument(furniture, "Furniture").IsNull().Throw();

            if (this.furnitures.Contains(furniture))
            {
                this.furnitures.Remove(furniture);
            }
        }

        public string Catalog()
        {
            var strBuilder = new StringBuilder();

            strBuilder.AppendLine($"{this.name} - {this.registrationNumber} - {(this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no")} {(this.Furnitures.Count != 1 ? "furnitures" : "furniture")}");

            foreach (IFurniture f in this.furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model))
            {
                strBuilder.AppendLine(f.ToString());
            }

            return strBuilder.ToString().Trim();
        }
    }
}
