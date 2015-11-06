
using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter sign to designate the card: ");
        string sign = Console.ReadLine();
        Console.Write("Valid card sign? - ");
        switch (sign)
        {
            case "2":
                Console.WriteLine("Yes!");
                break;
            case "3":
                Console.WriteLine("Yes!");
                break;
            case "4":
                Console.WriteLine("Yes!");
                break;
            case "5":
                Console.WriteLine("Yes!");
                break;
            case "6":
                Console.WriteLine("Yes!");
                break;
            case "7":
                Console.WriteLine("Yes!");
                break;
            case "8":
                Console.WriteLine("Yes!");
                break;
            case "9":
                Console.WriteLine("Yes!");
                break;
            case "10":
                Console.WriteLine("Yes!");
                break;
            case "J":
                Console.WriteLine("Yes!");
                break;
            case "D":
                Console.WriteLine("Yes!");
                break;
            case "Q":
                Console.WriteLine("Yes!");
                break;
            case "A":
                Console.WriteLine("Yes!");
                break;
            default:
                Console.WriteLine("No!");
                break;
        }
    }
}