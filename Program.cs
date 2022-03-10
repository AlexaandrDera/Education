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
}
