using System;

namespace Geometry
{
   
    public class Triangle : GeometricFigure
    {
        public double A { get; } 
        public double B { get; } 
        public double C { get; } 
        public double H { get; } 

        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            if (a <= 0 || b <= 0 || c <= 0 || h <= 0) throw new ArgumentException("Values must be positive");
            A = a;
            B = b;
            C = c;
            H = h;
        }

        public override double GetArea() => (B * H) / 2.0;
        public override double GetPerimeter() => A + B + C;
    }
}

