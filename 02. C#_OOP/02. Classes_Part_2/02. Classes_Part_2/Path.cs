namespace Classes_Part_2
{
    using Bytes2you.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Path
    {
        private static List<Point3D> path = new List<Point3D>();

        public static void Add(Point3D p)
        {
            path.Add(p);
        }
    }
}
