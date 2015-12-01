using System;
using _01.Shapes.Interfaces;

namespace _01.Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            IShape[] shapes =
            {
                new Circle(2.5),
                new Rectangle(11, 1.2),
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(
                    "This is a {0} with area: {1:f2} and perimeter {2:f2}",
                    shape.GetType().Name,
                    shape.CalculateArea(),
                    shape.CalculatePerimeter());
            }
        }
    }
}
