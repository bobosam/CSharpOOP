namespace Problem03.CompanyHierarchy
{
    using Problem03.CompanyHierarchy.Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal purchaseAmount;

        public Customer(string firstName, string lastName, long id, decimal purchaseAmount)
            : base(firstName, lastName, id)
        {
            this.PurchaseAmount = purchaseAmount;
        }

        public decimal PurchaseAmount
        {
            get
            {
                return this.purchaseAmount;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Purchase amount!");
                this.purchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nPurchase amount :" + this.PurchaseAmount;
        }
    }
}
