using System;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string Details { get; set; }

        string Name { get; set; }

        DateTime StartDate { get; set; }

        State State { get; set; }
    }
}