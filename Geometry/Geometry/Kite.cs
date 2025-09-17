using System;

namespace Geometry
{
    public class Kite : GeometricFigure
    {
        private double diagonal1;
        private double diagonal2;
        private double side1;
        private double side2;

        public Kite(string name, double diagonal1, double diagonal2, double side1, double side2)
            : base(name)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double GetArea()
        {
            return (diagonal1 * diagonal2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (side1 + side2);
        }
    }
}

