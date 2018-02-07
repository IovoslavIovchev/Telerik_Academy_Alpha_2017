using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.CompanyCommands
{
    public class ShowCompanyCatalogCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly Constants constants;

        public ShowCompanyCatalogCommand(IDatabase database, Constants constants)
        {
            this.database = database;
            this.constants = constants;
        }

        public string Execute(IList<string> args)
        {
            string companyName = args[0];

            if (!this.database.Companies.ContainsKey(companyName))
            {
                return string.Format(this.constants.CompanyNotFoundErrorMessage, companyName);
            }

            ICompany company = this.database.Companies[companyName];

            return company.Catalog();
        }
    }
}
