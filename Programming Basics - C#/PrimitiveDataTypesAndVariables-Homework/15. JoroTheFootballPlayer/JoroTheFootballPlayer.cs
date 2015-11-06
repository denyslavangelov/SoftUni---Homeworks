using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        // Input
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        int weekendsInYear = 52;
        int normalWeekends = weekendsInYear - weekendsHome;
       

        // Logic
        double gamesCount =
           normalWeekends * 2d / 3d +
           weekendsHome * 1d +
           holidays / 2d;
       
        if (leap == "t")
        {
            gamesCount = gamesCount + 3;
        }

        //Output
        Console.WriteLine((int)gamesCount);






    }
}

