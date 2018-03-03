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
        private IList<string> textLog;
    
        public Database()
        {
            this.companies = new Dictionary<string, ICompany>();
            this.furnitures = new Dictionary<string, IFurniture>();
            this.textLog = new List<string>();
        }

        public IDictionary<string, ICompany> Companies => this.companies;

        public IDictionary<string, IFurniture> Furnitures => this.furnitures;

        public IList<string> TextLog => this.textLog;

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

        public void Log(string msg)
        {
            if (msg == null)
            {
                throw new ArgumentNullException("String cannot be null");
            }

            this.textLog.Add(msg);
        }
    }
}
