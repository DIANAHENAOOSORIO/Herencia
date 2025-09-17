using System;

namespace Geometry
{
    
    public class Rhombus : GeometricFigure
    {
        public double A { get; }   
        public double D1 { get; }  
        public double D2 { get; }  

        public Rhombus(string name, double a, double d1, double d2) : base(name)
        {
            if (a <= 0 || d1 <= 0 || d2 <= 0) throw new ArgumentException("Values must be positive");
            A = a;
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2.0;
        public override double GetPerimeter() => 4 * A;
    }
}
