namespace Problem01.Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesMain
    {
        public static void Main()
        {
            var rectangle = new Rectangle(2.5, 4);
            var rhombus = new Rhombus(3, 2.5);
            var circle = new Circle(4);

            List<IShape> shapes = new List<IShape>() { rectangle, rhombus, circle };

            foreach (var shape in shapes)
            {
                double area = shape.CalculateArea();
                double perimeter = shape.CalculatePerimeter();

                Console.WriteLine("Type -->{0}", shape.GetType().Name);
                Console.WriteLine("\tPerimeter -->{0:0.00}", perimeter);
                Console.WriteLine("\tArea -->{0:0.00}", area);
                Console.WriteLine();
            }
        }
    }
}
