using System;

class Volleyball
{
    static void Main()
    {
        string leap = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsAtHome = int.Parse(Console.ReadLine());

        // All of the weekends in ONE year.
        int weekendsInYear = 48;

        // Weekends he plays football.
        int weekendsHePlays = weekendsInYear - weekendsAtHome;
        double hometownWeekendsPlaying = weekendsInYear - weekendsHePlays;
        double normalWeekendsPlaying = (double)weekendsHePlays * 3.0/ 4.0;
        double holidaysPlaying = (double)holidays * 2.0 / 3.0;
        double result = (int)normalWeekendsPlaying + holidaysPlaying + hometownWeekendsPlaying;

        if (leap == "leap")
        {
            Console.WriteLine(Math.Floor(result + 5.97));
        }
        else
        {
            Console.WriteLine(result);
        }
    }

     
}

