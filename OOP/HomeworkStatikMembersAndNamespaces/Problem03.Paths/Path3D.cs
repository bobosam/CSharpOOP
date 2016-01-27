namespace Problem03.Paths
{
    using System.Collections.Generic;
    using System.Text;
    using Problem01.Point3D;

    public class Path3D
    {
        private List<Point3D> points;

        public Path3D(params Point3D[] points)
        {
            this.points = new List<Point3D>();
            this.points.AddRange(points);
        }

        public IEnumerable<Point3D> Path
        {
            get { return this.points; }
        }

        public override string ToString()
        {
            var viewPath = new StringBuilder();

            viewPath.Append("Path\t{\n\n\t");
            viewPath.Append(string.Join("\t", this.points));
            viewPath.Append("\n\t}");

            return viewPath.ToString();
        }
    }
}
