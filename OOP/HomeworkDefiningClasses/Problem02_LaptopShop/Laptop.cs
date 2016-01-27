namespace Problem02_LaptopShop
{
    using System.Text;

    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string rAM;
        private string graphicsCard;
        private string hDD;
        private string screen;
        private Battery battery;
        private double? batteryLife;
        private decimal price;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(
                        string model,
                        decimal price,
                        string manufacturer = null,
                        string procesor = null,
                        string rAM = null,
                        string graphicsCard = null,
                        string hDD = null,
                        string screen = null,
                        Battery battery = null,
                        double? batteryLife = null) : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = procesor;
            this.RAM = rAM;
            this.GraphicsCard = graphicsCard;
            this.HDD = hDD;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Model!\n");
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Manufacturer!\n");
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Processor!\n");
                this.processor = value;
            }
        }

        public string RAM
        {
            get
            {
                return this.rAM;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "RAM!\n");
                this.rAM = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Graphics Card!\n");
                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hDD;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "HDD\n");
                this.hDD = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Screen\n");
                this.screen = value;
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
                Validate.CheckForPositiveValue(value, "Price!\n");
                this.price = value;
            }
        }

        public double? BatteryLife
        {
            get
            {
                return this.batteryLife;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Battery Life!\n");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine("model\t\t" + this.model);

            if (null != this.manufacturer)
            {
                output.AppendLine("manufacturer\t" + this.manufacturer);
            }

            if (null != this.processor)
            {
                output.AppendLine("processor\t" + this.processor);
            }

            if (null != this.rAM)
            {
                output.AppendLine("RAM\t\t" + this.rAM);
            }

            if (null != this.graphicsCard)
            {
                output.AppendLine("graphics card\t" + this.graphicsCard);
            }

            if (null != this.hDD)
            {
                output.AppendLine("HDD\t\t" + this.hDD);
            }

            if (null != this.screen)
            {
                output.AppendLine("screen\t\t" + this.screen);
            }

            if (null != this.battery)
            {
                output.AppendLine("battery\t\t" + this.battery.ToString());
                if (null != this.batteryLife)
                {
                    output.AppendLine("battery life\t" + this.batteryLife + " hours");
                }
            }

            string priceStr = string.Format("{0:0.00} lv.", this.price);
            output.AppendLine("price\t\t" + priceStr);

            return output.ToString();
        }
    }
}
