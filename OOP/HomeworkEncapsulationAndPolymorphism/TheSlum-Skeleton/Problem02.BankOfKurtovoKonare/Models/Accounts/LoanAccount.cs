namespace Problem02.BankOfKurtovoKonare.Models.Accounts
{
    using Problem02.BankOfKurtovoKonare.Interfaces;
    using Problem02.BankOfKurtovoKonare.Models.Customers;

    public class LoanAccount : Account
    {
        private const int MinimalIndividualMonths = 3;
        private const int MinimalCompanyMonths = 2;

        public LoanAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            Validate.CheckForPositiveValue(months, "Months");
            if (this.Customer is Individual)
            {
                if (MinimalIndividualMonths >= months)
                {
                    return 0;
                }

                months -= MinimalIndividualMonths;
            }

            if (this.Customer is Company)
            {
                if (MinimalCompanyMonths >= months)
                {
                    return 0;
                }

                months -= MinimalCompanyMonths;
            }

            return base.CalculateInterest(months);
        }
    }
}
