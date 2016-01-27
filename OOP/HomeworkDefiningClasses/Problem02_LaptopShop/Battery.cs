namespace Problem02_LaptopShop
{
    public class Battery
    {
        private string type;
        private int cells;
        private int capacity;

        public Battery(string type, int cells, int capacity)
        {
            this.Type = type;
            this.Cells = cells;
            this.Capacity = capacity;
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                Validate.CheckForNullOrEmptyString(value, "Battery type.\n");
                this.type = value;
            }
        }

        public int Cells
        {
            get
            {
                return this.cells;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Count of cells!\n");
                this.cells = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Capacity!\n");
                this.capacity = value;
            }
        }

        public override string ToString()
        {
            string batteryString = this.type + ", " + this.cells + "-cells, " + this.capacity + "mAh";

            return batteryString;
        }
    }
}
