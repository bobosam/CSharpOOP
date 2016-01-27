namespace Problem04_SoftwareUniversity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Problem04_SoftwareUniversity.Students;
    using Problem04_SoftwareUniversity.Trainers;

    public class SULSTest
    {
        public static void Main()
        {
            var persons = new List<Person>()
            {
               new OnlineStudent("Ivo", "Ivov", 25, 15478, 4.55, "C#"),
               new OnlineStudent("Pepo", "Pepov", 18, 165165, 3.78, "HTML5"),
               new OnsiteStudent("Gogo", "Gogov", 22, 16561, 4.44, "java", 4),
               new DropoutStudent("Ivo", "Pepov", 17, 1566, 3.15, "Go home."),
               new GraduateStudent("Pepo", "Gogov", 44, 6561, 4.78),
               new JuniorTrainer("Ivo", "Gogov", 27),
               new SeniorTrainer("Gogo", "Pepov", 38)
            };

            persons
                .OfType<CurrentStudent>()
                .OrderBy(student => student.AverageGrade)
                .ToList()
                .ForEach(Console.WriteLine);

            var dropout = new DropoutStudent("Ivo", "Pepov", 17, 1566, 3.15, "Go home.");
            dropout.Reapply();
        }
    }
}
