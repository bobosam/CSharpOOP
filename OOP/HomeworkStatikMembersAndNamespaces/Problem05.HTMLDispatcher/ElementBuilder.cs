namespace Problem05.HTMLDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ElementBuilder
    {
        private string elementName;
        private List<string[]> attributes = new List<string[]>();
        private string content;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName
        {
            get
            {
                return this.elementName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("\nThe name can not be empty string");
                }

                this.elementName = value;
            }
        }

        public static string operator *(ElementBuilder element, int count)
        {
            string result = string.Empty;

            if (1 > count)
            {
                throw new ArgumentOutOfRangeException("\nThe count can not be less than one!");
            }

            string elementHTML = element.ToString();

            for (int i = 0; i < count; i++)
            {
                result += elementHTML;
            }

            return result;
        }

        public void AddAttribute(string attribute, string value)
        {
            string[] attributeStr = { attribute, value };
            this.attributes.Add(attributeStr);
        }

        public void AddContent(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new ArgumentNullException("\nThe content can not be enpty string!");
            }

            this.content = content;
        }

        public override string ToString()
        {
            StringBuilder viewElement = new StringBuilder();
            viewElement.Append("<").Append(this.elementName);

            if (0 < this.attributes.Count())
            {
                foreach (var attribute in this.attributes)
                {
                    viewElement.Append(" ").Append(attribute[0]).Append("=\"").Append(attribute[1]).Append("\"");
                }
            }

            viewElement.Append(">");
            viewElement.Append(this.content).Append("</").Append(this.elementName).Append(">");

            return viewElement.ToString();
        }
    }
}
