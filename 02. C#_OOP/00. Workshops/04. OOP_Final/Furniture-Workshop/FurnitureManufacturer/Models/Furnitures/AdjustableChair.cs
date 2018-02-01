using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class AdjustableChair : Chair, IAdjustableChair
    {
        private decimal height;

        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
        }

        public void SetHeight(decimal height)
        {
            this.height = height;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
