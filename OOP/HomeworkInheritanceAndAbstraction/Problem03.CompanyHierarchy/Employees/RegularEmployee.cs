namespace Problem03.CompanyHierarchy.Employees
{
    public abstract class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName, string lastName, long id, decimal salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
        }
    }
}
