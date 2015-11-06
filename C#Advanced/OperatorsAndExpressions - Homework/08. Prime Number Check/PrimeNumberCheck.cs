using System;

class Program
{
    static void Main()
    {
        try
        {
            int num = int.Parse(Console.ReadLine()); ;
            int counter = (int)Math.Sqrt(num);
            bool isPrime = true;
            if (num > 1)
            {
                for (int cnt = 2; cnt <= counter; cnt++)
                {
                    if (num % cnt == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime ? "The number {0} is prime number." :
                "The number {0} is composite number.", num);
        }
        catch
        {
            Console.WriteLine("Invalid Input.");
        }
    }
}