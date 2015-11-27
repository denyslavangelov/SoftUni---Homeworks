using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    public class Project : IProject
    {
        public Project(string projectName, DateTime startDate, State state, string details)
        {
            this.Name = projectName;
            this.StartDate = startDate;
            this.State = state;
            this.Details = details;
        }

        public Project(string projectName, string details = null)
            : this(projectName, DateTime.Now, State.Open, details)
        {
        }

        public string Details { get; set; }

        public string Name { get; set; }    

        public DateTime StartDate { get; set; }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

    }
}