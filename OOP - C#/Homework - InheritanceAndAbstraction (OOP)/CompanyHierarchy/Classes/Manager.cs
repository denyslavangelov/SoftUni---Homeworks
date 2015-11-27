using System.Collections.Generic;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Manager : Employee, IManager
    {
        public Manager(string firstName, string lastName, int id, decimal salary, Department department, List<IEmployee> employeesManaged)
            : base (firstName, lastName, id, salary, department)
        {
            this.EmployeesManaged = employeesManaged;
        }

        public Manager(string firstName, string lastName, int id, decimal salary, Department department, IEmployee employeesManaged)
            : this(firstName, lastName, id, salary, department, new List<IEmployee> {employeesManaged})
        {
        }

        public List<IEmployee> EmployeesManaged { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Role: Manager\n");
            output.AppendFormat("Employees managed: ");

            List<string> employeeNames = new List<string>();

            foreach (Employee employee in EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}", employee.FirstName, employee.LastName));
            }

            output.AppendFormat(string.Join(", ", employeeNames) + "\n");
            return output.ToString();
        }
    }
}
