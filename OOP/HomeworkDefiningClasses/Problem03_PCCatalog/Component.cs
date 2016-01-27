namespace Problem03_PCCatalog
{
    public class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details)
            : this(name, price)
        {
            this.Details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Name\n");
                this.name = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Details\n");
                this.details = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validate.CheckForPositivPrice(value, "Price\n");
                this.price = value;
            }
        }
    }
}
