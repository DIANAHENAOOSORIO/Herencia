using System;

namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double side;

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }
}
