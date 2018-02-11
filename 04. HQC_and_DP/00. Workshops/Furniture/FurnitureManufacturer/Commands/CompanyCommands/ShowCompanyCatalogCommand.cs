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

        public void Execute(IList<string> args)
        {
            string companyName = args[0];

            if (!this.database.Companies.ContainsKey(companyName))
            {
                this.database.Log(string.Format(this.constants.CompanyNotFoundErrorMessage, companyName));

                return;
            }

            ICompany company = this.database.Companies[companyName];

            this.database.Log(company.Catalog());
        }
    }
}
