namespace Classes_Part_2
{
    using Bytes2you.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Path
    {
        private List<Point3D> path;

        public Path()
        {
            this.path = new List<Point3D>();
        }

        public void Add(Point3D p)
        {
            this.path.Add(p);
        }

        public List<Point3D> Points
        {
            get
            {
                return this.path;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var point in path)
            {
                result.AppendLine(point.ToString());
            }

            return result.ToString();
        }
    }
}
