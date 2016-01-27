namespace Problem03.Paths
{
    using System.Collections.Generic;
    using System.IO;
    using Problem01.Point3D;

    public static class Storage
    {
        public static void SavePath(Path3D path, string destination)
        {
            using (FileStream stream = File.Open(destination, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (var point in path.Path)
                {
                    writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
                }
            }
        }

        public static Path3D LoadPath(string destination)
        {
            List<Point3D> points = new List<Point3D>();
            using (StreamReader reader = new StreamReader(destination))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }

                    string[] pointCoordinates = line.Split(' ');
                    double x = double.Parse(pointCoordinates[0]);
                    double y = double.Parse(pointCoordinates[1]);
                    double z = double.Parse(pointCoordinates[2]);

                    Point3D point = new Point3D(x, y, z);
                    points.Add(point);
                }

                Path3D path = new Path3D(points.ToArray());

                return path;
            }
        }
    }
}
