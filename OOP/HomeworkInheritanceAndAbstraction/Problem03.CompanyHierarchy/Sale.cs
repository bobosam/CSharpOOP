namespace Problem03.CompanyHierarchy
{
    using System;

    public class Sale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, decimal price, DateTime date)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Date = date;
        }

        public DateTime Date { get; set; }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Product name!");
                this.productName = value;
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
                Validate.CheckForPositiveValue(value, "Price !");
                this.price = value;
            }
        }

        public override string ToString()
        {
            var viewSale = string.Format("Product name :{0}\n\tDate :{1}\n\tPrice :{2}", this.ProductName, this.Date, this.Price);

            return viewSale;
        }
    }
}
