namespace Problem03.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Problem03.CompanyHierarchy.Employees;

    public class TestCompany
    {
        public static void Main()
        {
            Developer developer = new Developer(
                "Ivan",
                "Ivanov",
                123456,
                4500.00m,
                Department.Production,
                new List<Project>()
                {
                    new Project("HTML", "web", DateTime.Now, ProjectState.Open),
                    new Project("MVC", "ASP", DateTime.Now, ProjectState.Closed)
                });

            SalesEmployee sales = new SalesEmployee(
                "Pepo",
                "Pepov",
                1516416,
                2500.00m,
                Department.Accounting,
                       new List<Sale>()
                       {
                            new Sale("HDD", 45.00m, DateTime.Now),
                            new Sale("RAM", 24.00m, DateTime.Now)
                       });

            Manager manager = new Manager("Gogo", "Gogov", 16161, 8500.00m, Department.Marketing, new List<Employee>() { developer, sales });

            var employees = new List<Employee>() { developer, sales, manager };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
