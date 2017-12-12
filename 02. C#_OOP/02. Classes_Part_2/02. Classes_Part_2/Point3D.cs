namespace Classes_Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Text;

    struct Point3D
    {
        private double x { get; set; }
        private double y { get; set; }
        private double z { get; set; }

        private static readonly Point3D o = new Point3D(0, 0, 0);

        public static Point3D O
        {
            get
            {
                return o;
            }
        }

        public Point3D (double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
        }

        public override string ToString()
        {
            return $"{{{x}, {y}, {z}}}";
        }
    }
}
