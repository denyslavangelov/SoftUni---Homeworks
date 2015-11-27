using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        List<IProject> Projects { get; set; }
    }
}