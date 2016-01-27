namespace Problem01.Point3D
{
    using System.Text;

    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint
        {
            get { return Point3D.StartingPoint; }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            var viewPoint = new StringBuilder();
            viewPoint.AppendLine("Point 3D:");
            viewPoint.AppendLine("\tX --> " + this.X);
            viewPoint.AppendLine("\tY --> " + this.Y);
            viewPoint.AppendLine("\tZ --> " + this.Z);
            viewPoint.AppendLine();

            return viewPoint.ToString();
        }
    }
}
