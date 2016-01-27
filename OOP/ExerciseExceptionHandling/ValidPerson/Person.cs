using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPerson
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.Lastname = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                Validate.CheckForNullOrEmptyString(value, "first name\n");
                this.firstName = value;
            }
        }

        public string Lastname
        {
            get { return this.lastName; }
            set
            {
                Validate.CheckForNullOrEmptyString(value, "last name\n");
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (0 > value || 120 < value)
                {
                    throw new ArgumentOutOfRangeException("The Age must be in range [0...120]");
                }

                this.age = value;
            }
        }
    }
}
