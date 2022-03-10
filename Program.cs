using System;

namespace Metanit
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle { Width = 20, Height = 10 };
            var circle = new Circle { Radius = 5 };

            PrintShape(rectangle);
            PrintShape(circle);

            void PrintShape(Shape shape)
            {
                Console.WriteLine($"Perimetr: {shape.GetPerimetr()} Area: {shape.GetArea()}");
            }
        }
    }

    abstract class Shape
    {
        public abstract double GetPerimetr();

        public abstract double GetArea();
    }

    class Rectangle : Shape
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public override double GetPerimetr() => Width * 2 + Height * 2;

        public override double GetArea() => Width * Height;
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetPerimetr() => Radius * 2 * Math.PI;
        public override double GetArea() => Radius * Radius * Math.PI;
    }
}
