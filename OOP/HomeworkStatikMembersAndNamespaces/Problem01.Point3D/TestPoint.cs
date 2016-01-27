namespace Problem01.Point3D
{
    using System;

    public class TestPoint
    {
        public static void Main()
        {
            var point = new Point3D(3.5, 4, 12);

            Console.WriteLine(point);
            Console.WriteLine(Point3D.StartPoint);
        }
    }
}
