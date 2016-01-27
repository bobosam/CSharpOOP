namespace Problem01.Shapes
{
    public class Rectangle : BasicShape, IShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (this.Height + this.Width) * 2;

            return perimeter;
        }
    }
}
