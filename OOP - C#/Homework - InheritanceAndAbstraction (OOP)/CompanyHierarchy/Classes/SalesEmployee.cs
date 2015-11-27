using System.Collections.Generic;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Department department, List<ISale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }

        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Department department, ISale sale)
           : this(firstName, lastName, id, salary, department, new List<ISale>() { sale})
        {
        }


        public List<ISale> Sales { get; set; }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("Role: Sales Employee\n");
            result += string.Format("Sales made: {0}\n", this.Sales.Count);
            return result;
        }
    }
}
