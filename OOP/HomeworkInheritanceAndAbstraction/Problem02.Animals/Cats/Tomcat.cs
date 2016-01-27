namespace Problem02.Animals.Cats
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Gender = Gender.Male;
        }
    }
}
