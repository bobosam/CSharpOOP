namespace Problem01.Shapes
{
    public class Rhombus : BasicShape, IShape
    {
        public Rhombus(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 4 * this.Width;

            return perimeter;
        }
    }
}
