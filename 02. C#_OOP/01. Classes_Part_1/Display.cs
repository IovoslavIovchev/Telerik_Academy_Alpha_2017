namespace Classes_Part_1
{
    using System;

    public class Display
    {
        private double size { get; set; }

        private uint numberOfColours { get; set; }

        public Display()
        {
            this.size = 0.00;

            this.numberOfColours = 0;
        }

        public Display(double size, uint numberOfColours)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Invalid Display Size");
            }

            this.size = size;

            this.numberOfColours = numberOfColours;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Display Size");
                }

                this.size = value;
            }
        }

        public uint NumberOfColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Display Size");
                }
                
                this.numberOfColours = value;
            }
        }
    }
}