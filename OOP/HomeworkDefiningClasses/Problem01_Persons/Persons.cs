namespace Problem01_Persons
{
    using System;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null)
        {
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Tne name must be non-empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (1 > value || 100 < value)
                {
                    throw new ArgumentOutOfRangeException("The age must be in range [1, 100]");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (null != value && !value.Contains("@"))
                {
                    throw new ArithmeticException("Wrong email!");
                }

                this.email = value;
            }
        }

        public override string ToString()
        {
            string personInfo = "Name --> " + this.name + "\nAge --> " + this.age;
            if (!string.IsNullOrEmpty(this.email))
            {
                personInfo += "\nEmail --> " + this.email + "\n";
            }

            return personInfo;
        }
    }
}
