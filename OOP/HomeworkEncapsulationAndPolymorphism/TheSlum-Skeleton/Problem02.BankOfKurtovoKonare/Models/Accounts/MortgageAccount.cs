namespace Problem02.BankOfKurtovoKonare.Models.Accounts
{
    using Problem02.BankOfKurtovoKonare.Interfaces;
    using Problem02.BankOfKurtovoKonare.Models.Customers;

    public class MortgageAccount : Account
    {
        private const int MinimumIndividualMonths = 6;
        private const int MinimumCompanyMonths = 12;
        private const int Factor = 2;

        public MortgageAccount(ICustomer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            Validate.CheckForPositiveValue(months, "Months!");
            if (this.Customer is Individual)
            {
                if (MinimumIndividualMonths >= months)
                {
                    return 0;
                }
                else
                {
                    months = months - MinimumIndividualMonths;
                }
            }

            if (this.Customer is Company)
            {
                if (MinimumCompanyMonths >= months)
                {
                    months = months / Factor;
                }
                else
                {
                    months = (months - MinimumCompanyMonths) + (MinimumCompanyMonths / Factor);
                }
            }

            return base.CalculateInterest(months);
        }
    }
}
