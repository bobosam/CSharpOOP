namespace Problem01.GalacticGPS
{
    public struct Location
    {
        private const double LatitudeMax = 90;
        private const double LatitudeMin = -90;
        private const double LongitudeMax = 180;
        private const double LongitudeMin = -180;

        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Planet = planet;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }

        public Planet Planet { get; private set; }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            private set
            {
                Validator.ChekValueInRange(value, LatitudeMin, LatitudeMax, "latitude");
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            private set
            {
                Validator.ChekValueInRange(value, LongitudeMin, LongitudeMax, "longitude");
                this.longitude = value;
            }
        }

        public override string ToString()
        {
            var viewPlanet = string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);

            return viewPlanet;
        }
    }
}
