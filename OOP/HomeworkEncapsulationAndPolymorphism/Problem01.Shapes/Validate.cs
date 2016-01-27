namespace Problem01.Shapes
{
    using System;

    public static class Validate
    {
        public static void CheckForNegativValue(double value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException("The argument must be positive value!", argument);
            }
        }
    }
}
