namespace Problem04_SoftwareUniversity.Students
{
    using System.Text;

    public abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Student number!\n");
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get
            {
                return this.averageGrade;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Average Grade!\n");
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine("Student Number --> " + this.studentNumber);
            result.AppendLine("Average grade --> " + this.averageGrade);

            return result.ToString();
        }
    }
}
