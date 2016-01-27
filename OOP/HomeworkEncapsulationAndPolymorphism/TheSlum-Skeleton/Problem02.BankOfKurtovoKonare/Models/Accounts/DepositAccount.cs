namespace Problem02.BankOfKurtovoKonare.Models.Accounts
{
    using Problem02.BankOfKurtovoKonare.Interfaces;

    public class DepositAccount : Account
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(decimal money)
        {
            Validate.CheckForPositiveValue(money, "Money!");
            Validate.CheckForPositiveValue(this.Balance - money, "Balance");
            this.Balance -= money;
        }

        public override decimal CalculateInterest(int months)
        {
            Validate.CheckForPositiveValue(months, "Months");
            if (1000 > this.Balance)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
