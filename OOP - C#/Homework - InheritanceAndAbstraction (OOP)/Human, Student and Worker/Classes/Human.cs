namespace HumanStudentandWorker
{
    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.Name = firstName;
            this.LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
