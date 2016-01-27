namespace Problem02.BankOfKurtovoKonare
{
    using System;

    public static class Validate
    {
        public static void CheckForPositiveValue(decimal value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException("The value must be positive!", argument);
            }
        }

        public static void CheckForEmptyString(string value, string argument)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("The argument must be non-empty string!", argument);
            }
        }
    }
}
