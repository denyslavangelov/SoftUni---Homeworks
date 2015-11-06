using System;

class EmployeeData
{
    static void Main()
    {

        // Input
        Console.WriteLine("Enter your first name : ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name : ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter your age : ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your gender : ");
        string gender = Console.ReadLine();

        Console.WriteLine("Enter your personal ID : ");
        int personalId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your unique ID : ");
        int uniqueId = int.Parse(Console.ReadLine());

        // Output
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("First name : {0}", firstName);
        Console.WriteLine("Last name : {0}", lastName);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("Personal ID : {0}", personalId);
        Console.WriteLine("Unique ID : {0}", uniqueId);

    }
}

