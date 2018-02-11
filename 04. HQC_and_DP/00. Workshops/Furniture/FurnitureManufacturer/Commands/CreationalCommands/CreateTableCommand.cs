using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.CreationalCommands
{
    public class CreateTableCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly IFurnitureFactory factory;
        private readonly Constants constants;

        public CreateTableCommand(IDatabase database, IFurnitureFactory factory, Constants constants)
        {
            this.database = database;
            this.factory = factory;
            this.constants = constants;
        }

        public void Execute(IList<string> args)
        {
            string model = args[0];

            if (this.database.Furnitures.ContainsKey(model))
            {
                this.database.Log(string.Format(this.constants.FurnitureExistsErrorMessage, model));

                return;
            }

            string material = args[1];

            decimal price = decimal.Parse(args[2]);

            decimal height = decimal.Parse(args[3]);

            decimal length = decimal.Parse(args[4]);

            decimal width = decimal.Parse(args[5]);

            IFurniture chair = this.factory.CreateTable(model, material, price, height, length, width);

            this.database.AddFurniture(chair);

            this.database.Log(string.Format(this.constants.TableCreatedSuccessMessage, model));
        }
    }
}
