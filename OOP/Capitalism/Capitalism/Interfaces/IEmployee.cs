using Capitalism.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; }

        string LastName { get; }

        IOrganizationUnit InUnit { get; }

        decimal SalaryFactor { get; }

        decimal TotalPaid { get; set; }

        decimal RecieveSalary(decimal percent, decimal ceoSalary);
    }
}
