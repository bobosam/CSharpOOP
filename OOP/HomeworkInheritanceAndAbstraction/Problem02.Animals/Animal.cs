namespace Problem02.Animals
{
    using System;

    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Gender Gender { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("The name must be non-empty string!");
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
                if (0 > value)
                {
                    throw new ArgumentOutOfRangeException("The age must be positive value!");
                }

                this.age = value;
            }
        }

        public abstract void ProduceSound();
    }
}
