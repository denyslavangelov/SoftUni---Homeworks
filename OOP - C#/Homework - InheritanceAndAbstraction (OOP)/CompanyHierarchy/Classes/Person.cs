using System;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private int id;
        private string lastName;

        protected Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("First name cannot be empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Last name cannot be empty.");
                }
                this.lastName = value;
            }
        }
        public int Id { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("First name: {0}\n", FirstName);
            output.AppendFormat("Last name: {0}\n", LastName);
            output.AppendFormat("ID: {0}\n", Id);
            return output.ToString();
        }
    }
}