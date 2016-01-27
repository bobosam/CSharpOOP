namespace Problem02.InterestCalculator
{
    using System;

    public class TestInterest
    {
        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal simpleInterest = sum * (1 + (interest * years));
            return simpleInterest;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal numberPerTimes = 12;
            decimal compoundInterest = sum * (decimal)Math.Pow(
                (double)(1 + (interest / numberPerTimes)),
                (double)(years * numberPerTimes));
            return compoundInterest;
        }

        public static void Main()
        {
            var simpleInterest = new InterestCalculator(2500m, 0.072m, 15, GetSimpleInterest);
            var compoundInterest = new InterestCalculator(500m, 0.056m, 10, GetCompoundInterest);

            Console.WriteLine("Simple interest --> {0}", simpleInterest);
            Console.WriteLine("Compound interest --> {0}\n", compoundInterest);
        }
    }
}
