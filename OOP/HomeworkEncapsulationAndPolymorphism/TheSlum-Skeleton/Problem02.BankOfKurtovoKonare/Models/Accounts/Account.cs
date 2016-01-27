namespace Problem02.BankOfKurtovoKonare.Models.Accounts
{
    using System.Text;
    using Problem02.BankOfKurtovoKonare.Interfaces;

    public abstract class Account
    {
        private const int MonthsInYear = 12;
        private decimal balance;
        private decimal interestRate;

        protected Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer { get; set; }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                Validate.CheckForPositiveValue(value, "Interest rate!");
                if (1 <= value)
                {
                    this.InterestRate = value / 100;
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                Validate.CheckForPositiveValue(value, "Balance");
                this.balance = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (this.InterestRate / MonthsInYear) * months;

            return interest;
        }

        public void DepositMoney(decimal money)
        {
            Validate.CheckForPositiveValue(money, "Money");
            this.Balance += money;
        }

        public override string ToString()
        {
            var viewAccount = new StringBuilder();
            viewAccount.AppendLine(this.Customer.ToString());
            viewAccount.AppendLine("Balance --> " + this.Balance + "lv.");
            viewAccount.AppendLine("Interest rate --> " + (this.InterestRate * 100) + "%");

            return viewAccount.ToString();
        }
    }
}
