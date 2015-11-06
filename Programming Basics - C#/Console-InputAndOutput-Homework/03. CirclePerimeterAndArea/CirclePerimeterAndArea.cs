using System;
using System.Threading;
using System.Globalization;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            // Input.
            Console.Write("Enter the radius : ");
            double radius = double.Parse(Console.ReadLine());

            // Calculate perimter and round it.
            double perimeter = (2 * Math.PI * radius);
            string roundedPerimter = perimeter.ToString("0.00");


            // Calculate area and round it.
            double area = (Math.PI * radius * radius);
            string roundedArea = area.ToString("0.00");

            Console.WriteLine();

            // Output.
            Console.WriteLine("The perimeter of the circle is : {0}", roundedPerimter);
            Console.WriteLine("The area of the circle is : {0}", roundedArea);


        }
    }

