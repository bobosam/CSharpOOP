namespace Problem02.DistanceCalculator
{
    using System;
    using Problem01.Point3D;

    public class TestDistanceCalculator
    {
        public static void Main()
        {
            var firstPoint = new Point3D(3.5, 12, 1.5);
            var secondPoint = new Point3D(4.2, 5.2, 3.2);

            double distance = DistanceCalculator.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:0.00}", distance);

            distance = DistanceCalculator.CalculateDistance(firstPoint, Point3D.StartPoint);
            Console.WriteLine("{0:0.00}", distance);
        }
    }
}
