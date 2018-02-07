using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;

namespace FurnitureManufacturer.Engine.Database
{
    public sealed class Database : IDatabase
    {
        private IDictionary<string, ICompany> companies;
        private IDictionary<string, IFurniture> furnitures;
    
        public Database()
        {
            this.companies = new Dictionary<string, ICompany>();
            this.furnitures = new Dictionary<string, IFurniture>();
        }

        public IDictionary<string, ICompany> Companies => this.companies;

        public IDictionary<string, IFurniture> Furnitures => this.furnitures;

        public void AddFurniture(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture cannot be null");
            }

            this.furnitures.Add(furniture.Model, furniture);
        }

        public void AddCompany(ICompany company)
        {
            if (company == null)
            {
                throw new ArgumentNullException("Companies cannot be null");
            }

            this.companies.Add(company.Name, company);
        }
    }
}
