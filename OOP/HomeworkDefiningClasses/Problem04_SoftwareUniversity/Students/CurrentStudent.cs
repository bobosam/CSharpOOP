namespace Problem04_SoftwareUniversity.Students
{
    using System.Text;

    public abstract class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Current course!\n");
                this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine("Current course --> " + this.currentCourse);

            return result.ToString();
        }
    }
}
