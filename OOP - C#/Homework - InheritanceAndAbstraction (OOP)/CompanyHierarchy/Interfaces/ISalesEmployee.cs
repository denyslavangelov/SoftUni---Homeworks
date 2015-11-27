using System.Collections.Generic;

namespace CompanyHierarchy.Interfaces
{
    public interface ISalesEmployee
    {
         List<ISale> Sales { get; }
    }
}