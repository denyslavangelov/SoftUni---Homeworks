using System;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy
{
    class MainClass
    {
        static void Main()
        {
            SalesEmployee retailer = new SalesEmployee("Borislav", "Krumov", 12, 500, Department.Marketing , new Sale("Book", 20.30m));

            Employee[] employees =
            {
                retailer,
                new Manager("Denislav", "Angelov", 15, 6500, Department.Marketing, retailer),
                new Developer("Katya", "Katerina", 16, 4500, Department.Production, new Project("Tic-Tac-Toe")),
                new SalesEmployee("Niki", "Mihov", 17, 3500, Department.Accounting, new Sale("Notebook", 4.50m))
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
