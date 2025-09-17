using System;

namespace Geometry
{
   
    public class Parallelogram : GeometricFigure
    {
        public double A { get; } 
        public double B { get; } 
        public double H { get; } 

        public Parallelogram(string name, double a, double b, double h) : base(name)
        {
            if (a <= 0 || b <= 0 || h <= 0) throw new ArgumentException("Values must be positive");
            A = a;
            B = b;
            H = h;
        }

        public override double GetArea() => B * H;
        public override double GetPerimeter() => 2 * (A + B);
    }
}
