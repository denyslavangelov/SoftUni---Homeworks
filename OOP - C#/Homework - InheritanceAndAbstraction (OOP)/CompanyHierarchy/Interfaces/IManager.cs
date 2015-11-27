using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    internal interface IManager
    {
        List<IEmployee> EmployeesManaged { get; set; }
    }
}