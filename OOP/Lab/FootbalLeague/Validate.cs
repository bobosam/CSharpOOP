using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public static class Validate
    {
        public static void CheckForNegativValue(dynamic value, string argument)
        {
            if (0 > value)
            {
                throw new ArgumentOutOfRangeException("\nThe argument must not to be negativ!", argument);
            }
        }

        public static void CheckForStringLength(string value, string argument, int length)
        {
            if (length > value.Length)
            {
                throw new ArgumentOutOfRangeException("\nThe argument should be at least 5 characters", argument);
            }
        }
    }
}
