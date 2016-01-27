namespace Problem01.BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price)
        : base(title, author, price)
        {
            this.Price = price + (0.30 * price);
        }
    }
}
