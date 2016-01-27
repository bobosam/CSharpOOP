namespace Problem02.InterestCalculator
{
    using System;

    public static class Validator
    {
        internal static void CheckForLargerThenZero(decimal value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException(argument);
            }
        }
    }
}
