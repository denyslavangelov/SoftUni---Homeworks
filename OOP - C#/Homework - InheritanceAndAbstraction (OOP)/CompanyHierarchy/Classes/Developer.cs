using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string firstName, string lastName, int id, decimal salary, Department department, List<IProject> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }

        public Developer(string firstName, string lastName, int id, decimal salary, Department department, IProject project)
            : this(firstName, lastName, id, salary, department, new List<IProject>() { project })
        {
        }

        public List<IProject> Projects { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Role: Developer\n");
            output.AppendFormat("Projects: ");

            List<string> projectNames = this.Projects.Select(project => project.Name).ToList();

            output.AppendFormat(string.Join(", ", projectNames) + "\n");
            return output.ToString();
        }
    }
}
