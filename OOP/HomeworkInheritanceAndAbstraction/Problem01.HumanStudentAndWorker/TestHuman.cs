namespace Problem01.HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestHuman
    {
        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Ivo1", "Ivov1", 111111),
                new Student("Ivo2", "Ivov2", 153467),
                new Student("Ivo3", "Ivov3", 333333),
                new Student("Ivo4", "Ivov4", 78542),
                new Student("Ivo5", "Ivov5", 555555),
                new Student("Ivo6", "Ivov6", 666666),
                new Student("Ivo7", "Ivov7", 777777),
                new Student("Ivo8", "Ivov8", 547896),
                new Student("Ivo9", "Ivov9", 478523),
                new Student("Ivo10", "Ivov10", 101010),
            };

            var workers = new List<Worker>()
            {
                new Worker("Pepo1", "Pepov1", 560.35m, 8),
                new Worker("Pepo2", "Pepov2", 860.44m, 8),
                new Worker("Pepo3", "Pepov3", 950.25m, 8),
                new Worker("Pepo4", "Pepov4", 220.44m, 4),
                new Worker("Pepo5", "Pepov5", 440.12m, 8),
                new Worker("Pepo6", "Pepov6", 350.14m, 8),
                new Worker("Pepo7", "Pepov7", 1500m, 7),
                new Worker("Pepo8", "Pepov8", 356.21m, 8),
                new Worker("Pepo9", "Pepov9", 444.12m, 8),
                new Worker("Pepo10", "Pepov10", 560.05m, 8)
            };

            var orderedStudents = students.OrderBy(st => st.FacultyNumber);

            foreach (var st in orderedStudents)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();

            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(w.WeekSalary, w.WorkHoursPerDay));

            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            var mergeList = new List<Human>(students.Count + workers.Count);
            mergeList.AddRange(students);
            mergeList.AddRange(workers);

            var sortedMergeList = mergeList
                                            .OrderBy(h => h.FirstName)
                                            .ThenBy(h => h.LastName)
                                            .Select(h => new
                                            {
                                                Type = h.GetType().Name,
                                                FirstName = h.FirstName,
                                                LastName = h.LastName
                                            });

            foreach (var human in sortedMergeList)
            {
                Console.WriteLine("{0} {1} {2}", human.Type, human.FirstName, human.LastName);
            }
        }
    }
}
