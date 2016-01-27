namespace Problem03.CompanyHierarchy
{
    using Problem03.CompanyHierarchy.Interfaces;

    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private long id;

        protected Person(string firstName, string lastName, long id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get
            {
               return this.firstName;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "First name!");
                this.firstName = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "id !");
                this.id = value;
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
                Validate.CheckForNullOrEmptyString(value, "Last name !");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            var viewPerson = string.Format("First name: {0}\nLast name: {1}\n", this.FirstName, this.LastName);

            return viewPerson;
        }
    }
}
