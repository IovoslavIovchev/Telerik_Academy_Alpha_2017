using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Commands;
using FurnitureManufacturer.Interfaces.Engine;
using System.Collections.Generic;

namespace FurnitureManufacturer.Commands.CreationalCommands
{
    public class CreateChairCommand : ICommand
    {
        private readonly IDatabase database;
        private readonly IFurnitureFactory factory;
        private readonly Constants constants;

        public CreateChairCommand(IDatabase database, IFurnitureFactory factory, Constants constants)
        {
            this.database = database;
            this.factory = factory;
            this.constants = constants;
        }

        public string Execute(IList<string> args)
        {
            string model = args[0];

            if (this.database.Furnitures.ContainsKey(model))
            {
                return string.Format(this.constants.FurnitureExistsErrorMessage, model);
            }

            string material = args[1];

            decimal price = decimal.Parse(args[2]);

            decimal height = decimal.Parse(args[3]);

            int legs = int.Parse(args[4]);

            IFurniture chair = this.factory.CreateChair(model, material, price, height, legs);

            this.database.AddFurniture(chair);

            return string.Format(this.constants.ChairCreatedSuccessMessage, model);
        }
    }
}
