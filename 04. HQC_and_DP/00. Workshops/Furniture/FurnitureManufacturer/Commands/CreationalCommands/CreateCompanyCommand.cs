using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.CreationalCommands
{
    public class CreateCompanyCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly ICompanyFactory factory;
        private readonly Constants constants;

        public CreateCompanyCommand(IDatabase database, ICompanyFactory factory, Constants constants)
        {
            this.database = database;
            this.factory = factory;
            this.constants = constants;
        }

        public void Execute(IList<string> args)
        {
            string name = args[0];

            if (this.database.Companies.ContainsKey(name))
            {
                this.database.Log(string.Format(this.constants.CompanyExistsErrorMessage, name));

                return;
            }

            string registrationNum = args[1];

            ICompany company = this.factory.CreateCompany(name, registrationNum);

            this.database.AddCompany(company);

            this.database.Log(string.Format(this.constants.CompanyCreatedSuccessMessage, name));
        }
    }
}
