namespace Problem04_SoftwareUniversity.Students
{
    public class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Number of visits!\n");
                this.numberOfVisits = value;
            }
        }
    }
}
