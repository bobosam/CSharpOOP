namespace Problem01_Persons
{
    using System;

    public class PlayPerson
    {
        public static void Main()
        {
            Person first = new Person("Ivan", 25, "ivan@abv.bg");
            Person second = new Person("Gogo", 15);

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
