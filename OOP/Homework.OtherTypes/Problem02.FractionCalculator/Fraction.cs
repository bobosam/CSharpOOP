namespace Problem02.FractionCalculator
{
    using System;
    using System.Text;

    public struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }

            private set
            {
                if (0 == value)
                {
                    throw new DivideByZeroException("The denominator cannot be zero!");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            Fraction result = new Fraction();
            result.Numerator = (first.Numerator * second.denominator) + (second.Numerator * first.denominator);
            result.Denominator = first.Denominator * second.Denominator;

            return result;
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            Fraction result = new Fraction();
            result.Numerator = (first.Numerator * second.denominator) - (second.Numerator * first.denominator);
            result.Denominator = first.Denominator * second.Denominator;

            return result;
        }

        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;

            var viewFraction = new StringBuilder();
            viewFraction.AppendLine(string.Format("{0}", this.Numerator));
            viewFraction.AppendLine(string.Format("{0}", this.Denominator));
            viewFraction.AppendLine(string.Format("{0}", result));

            return viewFraction.ToString();
        }
    }
}
