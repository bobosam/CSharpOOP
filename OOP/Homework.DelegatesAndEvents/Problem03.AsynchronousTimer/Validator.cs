namespace Problem03.AsynchronousTimer
{
    using System;

    public static class Validator
    {
        internal static void CheckForLargerThenZero(int value, string argument)
        {
            if (0 >= value)
            {
                throw new ArgumentOutOfRangeException(argument);
            }
        }
    }
}
