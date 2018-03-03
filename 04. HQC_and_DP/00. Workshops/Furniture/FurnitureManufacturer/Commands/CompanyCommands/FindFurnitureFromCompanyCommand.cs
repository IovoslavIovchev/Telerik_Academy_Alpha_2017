using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.CompanyCommands
{
    public class FindFurnitureFromCompanyCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly Constants constants;

        public FindFurnitureFromCompanyCommand(IDatabase database, Constants constants)
        {
            this.database = database;
            this.constants = constants;
        }

        public void Execute(IList<string> args)
        {
            string companyName = args[0];

            string furnitureModel = args[1];

            if (!this.database.Companies.ContainsKey(companyName))
            {
                this.database.Log(string.Format(this.constants.CompanyNotFoundErrorMessage, companyName));

                return;
            }

            if (!this.database.Furnitures.ContainsKey(furnitureModel))
            {
                this.database.Log(string.Format(this.constants.FurnitureNotFoundErrorMessage, furnitureModel));

                return;
            }

            ICompany company = this.database.Companies[companyName];

            IFurniture furniture = this.database.Furnitures[furnitureModel];

            if (!company.Furnitures.Contains(furniture))
            {
                this.database.Log(string.Format(this.constants.FurnitureNotFoundErrorMessage, furnitureModel));

                return;
            }

            this.database.Log(furniture.ToString());
        }
    }
}
