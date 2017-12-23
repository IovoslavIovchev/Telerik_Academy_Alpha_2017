using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class Table : Furniture, ITable
    {
        private decimal length;

        private decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width) 
            : base(model, materialType, price, height)
        {
            Guard.WhenArgument(length, "Table Length").IsLessThan(0).Throw();
            Guard.WhenArgument(width, "Table Width").IsLessThan(0).Throw();

            this.length = length;
            this.width = width;
        }

        public decimal Length => this.length;

        public decimal Width => this.width;

        public decimal Area => this.width * this.length;

        public override string ToString()
        {
            return base.ToString() + $", Length: {this.length}, Width: {this.width}, Area: {this.Area}";
        }
    }
}
