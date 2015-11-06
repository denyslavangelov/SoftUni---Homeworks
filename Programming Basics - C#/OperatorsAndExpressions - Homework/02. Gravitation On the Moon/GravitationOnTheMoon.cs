using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your weight, please : ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic.
        double weightOfTheMoon = weight * 0.17d;

        // Output.
        Console.WriteLine("You'll weight {0} on the moon!", weightOfTheMoon);
    }
}

