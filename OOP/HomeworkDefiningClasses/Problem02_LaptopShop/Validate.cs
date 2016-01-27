namespace Problem02_LaptopShop
{
    using System;

    public static class Validate
    {
        public static void CheckForNullOrEmptyString(string value, string argument)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("\nThe argument must not to be empty string! ", argument);
            }
        }

        public static void CheckForPositiveValue(dynamic value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException("\nThe argument must be positive value!", argument);
            }
        }
    }
}
