using System;

class Trapezoids
{
    static void Main()
    {
        // Input.
        Console.Write("Enter the first base of the trapezoid : ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter the second base of the trapezoid : ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the trapezoid : ");
        double height = double.Parse(Console.ReadLine());

        //Logic
        double trapezoidArea = ((a + b) / 2) * height;

        // Output
        Console.WriteLine();
        Console.WriteLine("The area of the trapezoid is : {0}", trapezoidArea);


    }
}

