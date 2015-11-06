using System;

class QuadraticEquation
{
    static void Main()
    {
            // Input.
            Console.Write("Enter the first coefficient : ");
            double coefA = double.Parse(Console.ReadLine());
            
            Console.Write("Enter the second coefficient : ");
            double coefB = double.Parse(Console.ReadLine());

            Console.Write("Enter the third coefficient : ");
            double coefC = double.Parse(Console.ReadLine());

            // Calculate determinant.
            double determinant = (coefB * coefB) - (4 * coefA * coefC);

            Console.WriteLine();

            // Logic and output.
            if (determinant < 0)
            {
                Console.WriteLine("Determinant is less than 0 -- > No solution.");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("x1 = {0};", (-coefB - Math.Sqrt(determinant)) / (2 * coefA));
                Console.WriteLine("x2 = {0};", (-coefB + Math.Sqrt(determinant)) / (2 * coefA));
            }
            else
            {
                Console.WriteLine("Determinant is 0  -- > Solution : {0}", (-coefB / (2 * coefA)));
            }
           
    }	
}

