namespace Classes_Part_2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    static class Distance
    {
        private static double x1 = 0;
        private static double y1 = 0;
        private static double z1 = 0;
        private static double x2 = 0;
        private static double y2 = 0;
        private static double z2 = 0;

        public static double DistanceBetweenTwoPoints(Point3D A, Point3D B)
        {
            x1 = A.X; y1 = A.Y; z1 = A.Z;
            x2 = B.X; y2 = B.Y; z2 = B.Z;

            return Math.Sqrt(
                Math.Pow((x2-x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)
                );
        }
    }
}
