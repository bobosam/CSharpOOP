namespace Problem05.HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public static ElementBuilder CreateImage(string source, string alt, string title)
        {
            var element = new ElementBuilder("img");
            element.AddAttribute("src", source);
            element.AddAttribute("alt", alt);
            element.AddAttribute("title", title);

            return element;
        }

        public static ElementBuilder CreateURL(string url, string text)
        {
            var element = new ElementBuilder("a");

            element.AddAttribute("href", url);
            element.AddContent(text);

            return element;
        }

        public static ElementBuilder CreateInput(string type, string name, string value)
        {
            var element = new ElementBuilder("input");

            element.AddAttribute("type", type);
            element.AddAttribute("name", name);
            element.AddAttribute("value", value);

            return element;
        }
    }
}
