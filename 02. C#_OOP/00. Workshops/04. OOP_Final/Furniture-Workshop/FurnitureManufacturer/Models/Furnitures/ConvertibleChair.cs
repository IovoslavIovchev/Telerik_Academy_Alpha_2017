using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models.Furnitures
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;

        private decimal height;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.isConverted = false;
            this.height = base.Height;
        }

        public bool IsConverted => this.isConverted;

        public void Convert()
        {
            isConverted = !isConverted;

            this.height = this.isConverted ? 0.10M : base.Height;
        }

        public override string ToString()
        {
            return base.ToString() + $", State: {(this.isConverted ? "Converted" : "Normal")}";
        }
    }
}
