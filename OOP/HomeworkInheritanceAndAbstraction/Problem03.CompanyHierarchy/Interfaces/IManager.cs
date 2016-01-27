namespace Problem03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    using Problem03.CompanyHierarchy.Employees;

    public interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
