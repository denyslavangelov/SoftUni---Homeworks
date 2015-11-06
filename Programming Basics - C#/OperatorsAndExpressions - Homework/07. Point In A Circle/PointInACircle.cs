
using System;

class PointCircle
{
    static void Main()
    {
        // Input.
        Console.Write("Enter coordinate x of the point: ");
        float x = float.Parse(Console.ReadLine());

        Console.Write("Enter coordinate y of the point: ");
        float y = float.Parse(Console.ReadLine());

        // Logic
        byte radius = 2;
        bool inCircle = x * x + y * y <= radius * radius;

        // Output
        Console.WriteLine();
        Console.WriteLine("The cordinates of the point are in the circle : {0}", inCircle);
    }
}