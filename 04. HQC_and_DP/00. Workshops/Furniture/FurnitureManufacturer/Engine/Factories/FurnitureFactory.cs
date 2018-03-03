using FurnitureManufacturer.Engine.Common;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Engine;
using FurnitureManufacturer.Models.Furnitures;
using System;

namespace FurnitureManufacturer.Engine.Factories
{
    public class FurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            return new Table(model, this.GetMaterialType(materialType), price, height, length, width);
        }

        public IFurniture CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            return new Chair(model, this.GetMaterialType(materialType), price, height, numberOfLegs);
        }

        private MaterialType GetMaterialType(string material)
        {
            MaterialType materialType;

            if (Enum.TryParse(material, true, out materialType))
            {
                return materialType;
            }

            throw new ArgumentException($"Invalid material name: {material}");
        }
    }
}
