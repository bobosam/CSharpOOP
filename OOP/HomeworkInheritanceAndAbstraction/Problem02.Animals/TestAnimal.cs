namespace Problem02.Animals
{
    using System;
    using System.Linq;
    using Problem02.Animals.Cats;

    public class TestAnimal
    {
        public static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Popi", 3),
                new Frog("Gri", 2),
                new Kitten("Maq", 4),
                new Tomcat("Pepo", 5),
                new Dog("Sharo", 1),
                new Frog("Grigri", 3),
                new Kitten("Pasha", 2),
                new Tomcat("Kiko", 2)
            };

            var groups = animals.GroupBy(a => a.GetType().Name);

            foreach (var group in groups)
            {
                double average = group.Average(g => g.Age);
                Console.WriteLine("{0}s average age --> {1}", group.Key, average);
            }
        }
    }
}
