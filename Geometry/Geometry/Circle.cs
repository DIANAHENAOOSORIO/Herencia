using System;

namespace Geometry
{
    public class Circle : GeometricFigure
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
