namespace Problem01.Shapes
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                Validate.CheckForNegativValue(value, "width");
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                Validate.CheckForNegativValue(value, "height");
                this.height = value;
            }
        }

        public double CalculateArea()
        {
            double area = this.Height * this.Width;

            return area;
        }

        public abstract double CalculatePerimeter();
    }
}
