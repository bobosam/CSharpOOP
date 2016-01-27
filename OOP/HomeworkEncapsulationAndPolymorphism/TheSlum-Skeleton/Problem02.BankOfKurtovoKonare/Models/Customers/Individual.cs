namespace Problem02.BankOfKurtovoKonare.Models.Customers
{
    using System.Text;
    using Problem02.BankOfKurtovoKonare.Interfaces;

    public class Individual : Customer, ICustomer
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private long egn;

        public Individual(string telephonNumber, string address, string firstName, string secondName, string lastName, long egn)
            : base(telephonNumber, address)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.EGN = egn;
        }

        public long EGN
        {
            get
            {
                return this.egn;
            }

            private set
            {
                Validate.CheckForPositiveValue(value, "EGN");
                this.egn = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validate.CheckForEmptyString(value, "Last name!");
                this.lastName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }

            private set
            {
                Validate.CheckForEmptyString(value, "Second name!");
                this.secondName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validate.CheckForEmptyString(value, "First name!");
                this.firstName = value;
            }
        }

        public override string ToString()
        {
            var viewIndividual = new StringBuilder();
            viewIndividual.AppendLine("First name --> " + this.FirstName);
            viewIndividual.AppendLine("Second name --> " + this.SecondName);
            viewIndividual.AppendLine("Last name --> " + this.LastName);
            viewIndividual.AppendLine("EGN --> " + this.EGN);
            viewIndividual.AppendLine(base.ToString());

            return viewIndividual.ToString();
        }
    }
}
