using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {
        // Input.
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());

        string partOfDay = Console.ReadLine();
        string startExam = startHour + ":" + startMinutes + " " + partOfDay;

        int endHour = int.Parse(Console.ReadLine());
        int endMinutes = int.Parse(Console.ReadLine());


        DateTime start = DateTime.Parse(startExam);
        DateTime startPlusEndHour = start.AddHours(endHour);
        DateTime startPlusEndMinutes = startPlusEndHour.AddMinutes(endMinutes);

        string format = "hh:mm:tt";
        Console.WriteLine(startPlusEndMinutes.ToString(format, CultureInfo.InvariantCulture));
    }

}




