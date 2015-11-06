using System;

class Program
{
    static void Main()
    {
        // It took me some time, lol.


        // Input.
        int hoursToFinishProject = int.Parse(Console.ReadLine());
        int daysToFinishProject = int.Parse(Console.ReadLine());
        double percentProductivity = double.Parse(Console.ReadLine());

        // Calculate days and hours she actually works.
        double actualWorkDays = daysToFinishProject * 0.9d;
        double actualWorkingHours = actualWorkDays * 12;
        double workHours = actualWorkingHours * (percentProductivity / 100.0d);
        double efficientWorkHours = Math.Floor(workHours);

        // Logic and output.
        if (hoursToFinishProject <= efficientWorkHours)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(efficientWorkHours - hoursToFinishProject);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine(efficientWorkHours - hoursToFinishProject);
        }     
    }
}

