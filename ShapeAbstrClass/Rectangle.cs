namespace Metanit
{
    class Rectangle : Shape
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public override double GetPerimetr() => Width * 2 + Height * 2;

        public override double GetArea() => Width * Height;
    }

}
