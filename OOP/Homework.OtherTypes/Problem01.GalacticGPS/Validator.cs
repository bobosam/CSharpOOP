namespace Problem01.GalacticGPS
{
    using System;

    public static class Validator
    {
        public static void ChekValueInRange(double value, double minValue, double maxValue, string argument)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentOutOfRangeException(string.Format(
                                                        "The {0} must be in range [{1} - {2}]!",
                                                        argument,
                                                        minValue,
                                                        maxValue));
            }
        }
    }
}
