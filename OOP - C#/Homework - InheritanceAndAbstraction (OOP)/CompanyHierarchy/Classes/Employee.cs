using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(string firstName, string lastName, int id, decimal salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (salary < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative.");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }
    }
}
