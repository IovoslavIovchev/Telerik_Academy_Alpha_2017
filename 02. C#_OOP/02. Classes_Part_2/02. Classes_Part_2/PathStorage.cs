namespace Classes_Part_2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;

    static class PathStorage
    {
        public static Path Read(string file)
        {
            Path result = new Path();

            using (StreamReader sr = new StreamReader($"./{file}", Encoding.UTF8))
            {
                string temp = sr.ReadLine();
                while (temp != null)
                {
                    Match m = Regex.Match(temp, "{(.*?), (.*?), (.*?)}");

                    double x = double.Parse(m.Groups[1].Value);
                    double y = double.Parse(m.Groups[2].Value);
                    double z = double.Parse(m.Groups[3].Value);

                    result.Add(new Point3D(x, y, z));

                    temp = sr.ReadLine();
                }
            }

            return result;
        }

        public static void Write(string file, Path path)
        {
            if (!File.Exists($"./{file}"))
            {
                File.CreateText($"./{file}");
            }

            using (StreamWriter sw = new StreamWriter($"./{file}"))
            {
                foreach (var point in path.Points)
                {
                    sw.WriteLine(point);
                }
            }
        }
    }
}
