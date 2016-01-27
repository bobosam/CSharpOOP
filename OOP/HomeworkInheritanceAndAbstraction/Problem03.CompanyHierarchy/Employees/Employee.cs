namespace Problem03.CompanyHierarchy.Employees
{
    using Problem03.CompanyHierarchy.Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(string firstName, string lastName, long id, decimal salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public Department Department { get; set; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                Validate.CheckForPositiveValue(value, "Salary !");
                this.salary = value;
            }
        }

        public override string ToString()
        {
            var viewEmployee = base.ToString() + string.Format("Department : {0}\nSalary : {1}", this.Department, this.Salary);

            return viewEmployee;
        }
    }
}
