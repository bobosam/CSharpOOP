namespace Problem02.FractionCalculator
{
    using System;

    public class TestFraction
    {
        public static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);

            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result);

            result = fraction1 - fraction2;
            Console.WriteLine(result);
        }
    }
}
