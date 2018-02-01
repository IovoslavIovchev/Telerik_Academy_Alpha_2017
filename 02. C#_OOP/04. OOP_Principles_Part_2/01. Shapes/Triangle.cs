using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Principles_Part_2
{
    class Triangle : Shape
    {
        private double width;
        private double height;

        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateSurface()
        {
            return this.width * this.height / 2;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can't be 0 or less");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can't be 0 or less");
                }
                this.height = value;
            }
        }
    }
}
