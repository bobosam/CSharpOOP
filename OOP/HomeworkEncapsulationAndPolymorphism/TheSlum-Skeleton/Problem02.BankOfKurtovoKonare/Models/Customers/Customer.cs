namespace Problem02.BankOfKurtovoKonare.Models.Customers
{
    using System.Text;
    using Problem02.BankOfKurtovoKonare.Interfaces;
    
    public abstract class Customer : ICustomer
    {
        private string address;
        private string phoneNumber;

        public Customer(string phoneNumber, string address)
        {
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }

            set
            {
                Validate.CheckForEmptyString(value, "Telephone number!");
                this.phoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                Validate.CheckForEmptyString(value, "Address !");
                this.address = value;
            }
        }

        public override string ToString()
        {
            var viewCustomer = new StringBuilder();
            viewCustomer.AppendLine("Address --> " + this.Address);
            viewCustomer.AppendLine("Phone --> " + this.PhoneNumber);

            return viewCustomer.ToString();
        }
    }
}
