namespace Problem02.BankOfKurtovoKonare.Models.Customers
{
    using System.Text;
    using Problem02.BankOfKurtovoKonare.Interfaces;

    public class Company : Customer, ICustomer
    {
        private string companyName;
        private long ekpou;

        public Company(string telephonNumber, string address, string companyName, long ekpou)
            : base(telephonNumber, address)
        {
            this.CompanyName = companyName;
            this.EKPOU = ekpou;
        }

        public long EKPOU
        {
            get
            {
                return this.ekpou;
            }

            private set
            {
                Validate.CheckForPositiveValue(value, "EKPOU");
                this.ekpou = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            private set
            {
                Validate.CheckForEmptyString(value, "Company name!");
                this.companyName = value;
            }
        }

        public override string ToString()
        {
            var viewCompany = new StringBuilder();
            viewCompany.AppendLine("Company name --> " + this.CompanyName);
            viewCompany.AppendLine("EKPOU --> " + this.EKPOU);
            viewCompany.AppendLine(base.ToString());

            return viewCompany.ToString();
        }
    }
}
