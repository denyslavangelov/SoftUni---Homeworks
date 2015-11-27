using System;
using System.Text;

namespace HumanStudentandWorker
{
    public class Worker : Human
    {

        public Worker(string name, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(name, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal result = (WeekSalary / 7) / WorkHoursPerDay;
            return result;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("- Name: {0}\n", Name);
            output.AppendFormat("- Last Name: {0}\n", LastName);
            output.AppendFormat("- Weekly Salary: {0}\n", WeekSalary);
            output.AppendFormat("- Work hours per day: {0}\n", WorkHoursPerDay);
            output.AppendFormat("- Money per hour: {0:f2}\n", MoneyPerHour());
            return output.ToString();
        }
    }
}
