using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPerson
{
    public class PlayPerson
    {
        public static void Main()
        {
            //Person pesho = new Person("Ivo", "Ivov", 28);
            try
            {
                Person noname = new Person(string.Empty, "pepov", 88);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message); 
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            //Person nolast = new Person("Pepo", null, 55);
            //Person negativ = new Person("Gogo", "Gogov", -5);
            //Person old = new Person("Ivo", "Gogov", 121);
        }
    }
}
