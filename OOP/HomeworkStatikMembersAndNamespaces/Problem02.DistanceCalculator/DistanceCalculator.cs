namespace Problem02.DistanceCalculator
{
    using System;
    using Problem01.Point3D;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(((first.X - second.X) * (first.X - second.X)) +
                                        ((first.Y - second.Y) * (first.Y - second.Y)) +
                                        ((first.Z - second.Z) * (first.Z - second.Z)));

            return distance;
        }
    }
}
