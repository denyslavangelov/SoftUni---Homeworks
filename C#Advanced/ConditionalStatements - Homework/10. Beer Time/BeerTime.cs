using System;

class BeerTime
{
    static void Main()
    {
        try
        {
            // Input.
            Console.Write("Enter time : ");
            DateTime enteredTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(enteredTime.ToString("hh:mm tt"));

            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");

            // Logic and output.
            if (enteredTime >= startTime || enteredTime < endTime)
            {
                Console.WriteLine("Beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid Format.");
        }
    }
}

