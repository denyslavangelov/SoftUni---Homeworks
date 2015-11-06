using System;

class PrintCompanyInformation
{
    static void Main()
    {
         try
        {
            // Input
            Console.Write("Enter your company name : ");
            string companyName = Console.ReadLine();

            Console.Write("Enter your company adress : ");
            string companyAdress = Console.ReadLine();

            Console.Write("Enter your phone number : ");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your fax number : ");
            string faxNumber = Console.ReadLine();

            Console.Write("Enter your website : ");
            string webSite = Console.ReadLine();

            Console.Write("Enter your manager first name : ");
            string managerFirstName = Console.ReadLine();

            Console.Write("Enter your manager second name : ");
            string managerSecondName = Console.ReadLine();

            Console.Write("Enter your manager age : ");
            int managerAge = int.Parse(Console.ReadLine());

            Console.Write("Enter your manager phone number : ");
            string managerPhoneNumber = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();

            // Output.
            Console.WriteLine("Company name : {0}", companyName);
            Console.WriteLine("Company name : {0}", companyAdress);
            Console.WriteLine("Company name : {0}", phoneNumber);
            Console.WriteLine("Company name : {0}", faxNumber);
            Console.WriteLine("Company name : {0}", webSite);
            Console.WriteLine("Company name : {0}", managerFirstName);
            Console.WriteLine("Company name : {0}", managerSecondName);
            Console.WriteLine("Company name : {0}", managerAge);
            Console.WriteLine("Company name : {0}", managerPhoneNumber);
        }
         
            catch (Exception)
         {
             Console.WriteLine("Invalid input.");
             return;
         }




    }
}

