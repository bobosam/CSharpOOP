﻿namespace Problem02.Animals.Cats
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Gender = Gender.Female;
        }
    }
}
