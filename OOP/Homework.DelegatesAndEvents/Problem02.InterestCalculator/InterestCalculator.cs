namespace Problem02.InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int years);

    public class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private CalculateInterest type;

        public InterestCalculator(decimal money, decimal interest, int years, CalculateInterest type)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Type = type;
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, " Money must be positive!\n");
                this.money = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, " Interest must be positive!\n");
                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                Validator.CheckForLargerThenZero(value, " Years must be positive!\n");
                this.years = value;
            }
        }

        public CalculateInterest Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("{0:F4}", this.type(this.Money, this.Interest, this.Years));
            return result;
        }
    }
}
