namespace Problem01.BookShop
{
    using System;

    public class TestBook
    {
        public static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90);
            Console.WriteLine(book);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90);
            Console.WriteLine(goldenBook);
        }
    }
}
