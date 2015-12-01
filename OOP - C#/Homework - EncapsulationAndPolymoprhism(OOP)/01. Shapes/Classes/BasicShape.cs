using _01.Shapes.Interfaces;

namespace _01.Shapes
{
    public abstract class BasicShape : IShape
    {
        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public double Height { get; set; }

        public double Width { get; set; }
    }
}