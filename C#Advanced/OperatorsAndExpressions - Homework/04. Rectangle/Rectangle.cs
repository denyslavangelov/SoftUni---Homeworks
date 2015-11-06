using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle : ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle : ");
        double height = double.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("The width of the rectangle is : {0}", width);
        Console.WriteLine("The height of the rectangle is : {0}", height);

        // Formula for perimeter.
        double perimeter = 2 * (width + height);

        // Formula for area.
        double area = width * height;

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("The perimter of the rectangle is : {0}", perimeter);
        Console.WriteLine("The area of the rectangle is : {0}", area);



    }
}

