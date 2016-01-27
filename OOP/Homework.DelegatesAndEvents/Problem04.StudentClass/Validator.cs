namespace Problem04.StudentClass
{
    using System;

    public static class Validator
    {
        internal static void CheckForNullOrEmpty(string value, string argument)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException(argument);
            }
        }

        internal static void CheckForLargerThenZero(byte value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException(argument);
            }
        }
    }
}
