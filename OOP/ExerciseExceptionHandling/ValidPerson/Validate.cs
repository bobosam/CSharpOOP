using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPerson
{
    public static class Validate
    {
        public static void CheckForNullOrEmptyString(string value, string argument)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("\nThe argument schould be non-empty string!", argument);
            }
        }
    }
}
