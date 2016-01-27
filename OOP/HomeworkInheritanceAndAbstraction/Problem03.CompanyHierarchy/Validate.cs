namespace Problem03.CompanyHierarchy
{
    using System;
   
    public static class Validate
    {
        public static void CheckForNullOrEmptyString(string value, string argument)
        {
            if (string.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentNullException("The argumnet must be non-empty string!", argument);
            }
        }

        public static void CheckForPositiveValue(dynamic value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException("The value must be positive!", argument);
            }
        }
    }
}
