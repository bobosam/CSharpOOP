namespace Problem04_SoftwareUniversity.Trainers
{
    using System;

    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        private void DeleteCourse(string courseName)
        {
            Console.WriteLine("{0} is deleted.", courseName);
        }
    }
}
