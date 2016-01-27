namespace Problem03_PCCatalog
{
    using System;

    public static class Validate
    {
        public static void CheckForNullOrEmptyString(string value, string argument)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("\nThe argument must be non-empty string!", argument);
            }
        }

        public static void CheckForPositivPrice(decimal value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException("\nThe argument must be positive number!", argument);
            }
        }
    }
}
