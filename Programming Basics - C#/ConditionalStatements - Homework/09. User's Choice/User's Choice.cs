using System;

class usersChoice
{
    static void Main()
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type : ");
        int choose = int.Parse(Console.ReadLine());

        Console.Clear();
        switch (choose)
        {
            case 1: Console.Write("You choosed integer !\n\nPlease enter a integer : ");
                    int choosedInteger = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Result : {0}", choosedInteger + 1);
            break;
            case 2: Console.Write("You choosed double !\n\nPlease enter a double : ");
                    double choosedDouble = double.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Result : {0}", choosedDouble + 1);
            break;
            case 3: Console.Write("You choosed string !\n\nPlease enter a string : ");
                    string choosedString = Console.ReadLine();
                    string asterix = choosedString + '*';
                    Console.Clear();
                    Console.WriteLine("Result: {0}", asterix);
            break;

            default: Console.WriteLine("Not a valid type!");
            break;
        }

    }
}

