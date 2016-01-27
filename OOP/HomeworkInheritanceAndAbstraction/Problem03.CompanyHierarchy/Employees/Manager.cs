namespace Problem03.CompanyHierarchy.Employees
{
    using System.Collections.Generic;
    using System.Text;
    using Problem03.CompanyHierarchy.Interfaces;

    public class Manager : Employee, IManager
    {
        public Manager(string firstName, string lastName, long id, decimal salary, Department department, List<Employee> employees)
            : base(firstName, lastName, id, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            var viewManager = new StringBuilder();
            viewManager.AppendLine(base.ToString());
            viewManager.AppendLine("Employees :");

            foreach (var employee in this.Employees)
            {
                viewManager.AppendLine(employee.ToString());
            }

            return viewManager.ToString();
        }
    }
}
