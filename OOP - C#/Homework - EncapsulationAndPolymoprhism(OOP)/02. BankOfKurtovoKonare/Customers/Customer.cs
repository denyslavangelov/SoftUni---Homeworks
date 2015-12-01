using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public class Customer : ICustomer
    {
        public Customer(CustomerType type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

      

        public string Name { get; set; }
        public CustomerType Type { get; set; }
    }
}

