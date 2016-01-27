namespace Problem01.BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("The argument schould be non-empty string!");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("regg");
                }

                this.author = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (0 > value)
                {
                    throw new ArgumentOutOfRangeException("dgbdxb");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendLine("-Title: " + this.Title);
            output.AppendLine("-Author: " + this.Author);
            output.AppendFormat("-Price: {0:0.00}\r\n", this.Price);

            return output.ToString();
        }
    }
}
