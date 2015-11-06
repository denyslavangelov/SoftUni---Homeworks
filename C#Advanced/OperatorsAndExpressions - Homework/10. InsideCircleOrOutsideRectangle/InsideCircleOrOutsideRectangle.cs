using System;

class InsideCircleOrOutsideRectangle
{
    static void Main()
    {
        // Input.
        Console.Write("Enter cordinates for x : ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Enter cordinates for y : ");
        float y = float.Parse(Console.ReadLine());

        Console.WriteLine();


        // Logic

        // Circle's radius.
        double circleRadius = 1.5d;
        
        // Check if it is in the circle.
        bool inCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= (circleRadius * circleRadius);

        // Check if its our of the rectangle.
        bool outOfRectangle = (x <= 5 && x >= -1) && (y >= -1 && y <= 1);

        // Output

        // If both are true.
        if (inCircle && !outOfRectangle)
        {
        Console.WriteLine("Yes");
        }
        else
        {
        Console.WriteLine("No");
        }
    }   
}


