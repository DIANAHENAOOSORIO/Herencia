using System;

namespace Geometry
{
    public class Rectangle : GeometricFigure
    {
        private double width;
        private double height;

        public Rectangle(string name, double width, double height) : base(name)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
