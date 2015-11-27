using System;
using System.Text;

namespace HumanStudentandWorker
{
    public class Student : Human
    {
        private int facultyNumber;

        public Student(string name, string lastName, int facultyNumber)
            : base(name, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Faculty number must contain only numbers in the range of 5 and 10.");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("- Name: {0}\n", Name);
            output.AppendFormat("- Last Name: {0}\n", LastName);
            output.AppendFormat("- Faculty number: {0}\n", facultyNumber);
            return output.ToString();
        }
    }
}
