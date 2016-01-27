namespace Problem05.HTMLDispatcher
{
    using System;
    using System.Text;

    public class TestDispatcher
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ElementBuilder div = new ElementBuilder("div");

            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div);
            Console.WriteLine();

            ElementBuilder li = new ElementBuilder("li");
            Console.WriteLine(li * 5);

            ElementBuilder image = HTMLDispatcher.CreateImage(
                                                            "http://85.14.28.164/d/images/slideshows/0000095328-category.jpg",
                                                            "Прасе водач",
                                                            "Прасе водач");

            ElementBuilder url = HTMLDispatcher.CreateURL(
                                                        "http://www.dnes.bg/slideshow.php?mreporter&id=7065&pid=95328",
                                                        "Прасе водач");

            ElementBuilder input = HTMLDispatcher.CreateInput("text", "first name", "Submit");

            Console.WriteLine();
            Console.WriteLine(image);
            Console.WriteLine();
            Console.WriteLine(url);
            Console.WriteLine();
            Console.WriteLine(input);
            Console.WriteLine();
        }
    }
}
