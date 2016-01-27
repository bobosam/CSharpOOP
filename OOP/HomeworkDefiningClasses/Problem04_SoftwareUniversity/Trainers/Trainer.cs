namespace Problem04_SoftwareUniversity.Trainers
{
    using System;

    public abstract class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        protected void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} is created.", courseName);
        }
    }
}
