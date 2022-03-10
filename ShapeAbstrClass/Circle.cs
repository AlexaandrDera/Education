using System;

namespace Metanit
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetPerimetr() => Radius * 2 * Math.PI;
        public override double GetArea() => Radius * Radius * Math.PI;
    }

}
