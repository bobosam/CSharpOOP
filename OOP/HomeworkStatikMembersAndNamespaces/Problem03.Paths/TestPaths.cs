namespace Problem03.Paths
{
    using System;
    using System.IO;
    using Problem01.Point3D;

    public class TestPaths
    {
        public static void Main()
        {
            Point3D startPoint = Point3D.StartPoint;
            Point3D pointA = new Point3D(3.5, 4.2, 8);
            Point3D pointB = new Point3D(1, 17, 4.8);
            Point3D pointC = new Point3D(4.8, 1, 2);

            Path3D path = new Path3D(startPoint, pointA, pointB, pointC);

            try
            {
                Storage.SavePath(path, "path.txt");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Path3D pathLoaded = Storage.LoadPath("path.txt");
                Console.WriteLine(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
