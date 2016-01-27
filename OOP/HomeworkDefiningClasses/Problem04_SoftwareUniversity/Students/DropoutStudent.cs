namespace Problem04_SoftwareUniversity.Students
{
    using System;
    using System.Text;

    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Dropout Reason!\n");
                this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            var result = new StringBuilder();
            result.Append(this.ToString());
            result.AppendLine("Dropout reason --> " + this.dropoutReason);

            Console.WriteLine(result);
        }
    }
}
