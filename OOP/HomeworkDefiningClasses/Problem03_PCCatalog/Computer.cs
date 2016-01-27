namespace Problem03_PCCatalog
{
    using System.Collections.Generic;
    using System.Text;

    public class Computer
    {
        private string name;
        private decimal price;
        private List<Component> components = new List<Component>();

        public Computer(string name, params Component[] inputComponents)
        {
            this.Name = name;
            this.AddComponents(inputComponents);
            this.price = this.CalculatePrice(this.components);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "PC Name!\n");
                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
        }

        public override string ToString()
        {
            StringBuilder outputString = new StringBuilder();

            string computerStr = string.Format("{0} --> {1:0.00}лв.", this.Name, this.Price);
            outputString.AppendLine(computerStr);

            foreach (var component in this.components)
            {
                string componentStr = string.Format("\t{0} --> {1:0.00}лв.", component.Name, component.Price);
                outputString.AppendLine(componentStr);
            }

            return outputString.ToString();
        }

        private decimal CalculatePrice(List<Component> components)
        {
            decimal sumPrice = 0;

            foreach (var component in components)
            {
                sumPrice += component.Price;
            }

            return sumPrice;
        }

        private void AddComponents(Component[] inputComponents)
        {
            this.components = new List<Component>();
            foreach (var component in inputComponents)
            {
                this.components.Add(component);
            }
        }       
    }
}
