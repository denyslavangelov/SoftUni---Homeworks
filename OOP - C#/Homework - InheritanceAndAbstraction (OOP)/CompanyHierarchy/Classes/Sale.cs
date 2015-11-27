using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class Sale : ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, DateTime dateOfSale, decimal price)
        {
            this.ProductName = productName;
            this.DateOfSale = dateOfSale;
            this.Price = price;
        }

        public Sale(string productName, decimal price)
            : this(productName, DateTime.Now, price)
        {
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product name cannot be empty.");
                }
                this.productName = value;
            }
        }

        public DateTime DateOfSale { get; set; }
        public decimal Price { get; set; }
    }
}
