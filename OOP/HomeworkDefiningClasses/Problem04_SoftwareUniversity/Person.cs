namespace Problem04_SoftwareUniversity
{
    using System.Text;

    public abstract class Person
    {
        private string firtsName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firtsName;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "First Name!\n");
                this.firtsName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Last Name!\n");
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Age!\n");
                this.age = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("First Name --> " + this.firtsName);
            result.AppendLine("Last Name --> " + this.lastName);
            result.AppendLine("Age --> " + this.age);

            return result.ToString();
        }
    }
}
