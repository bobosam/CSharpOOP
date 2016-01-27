using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    using Interfaces;
    public class CEO : Employee
    {
        private const decimal CEOSalaryFactor = 0;
        public CEO(string firstName, string lastName, IOrganizationUnit inUnit, decimal salary)
            :base(firstName, lastName, inUnit, CEOSalaryFactor)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override decimal RecieveSalary(decimal percent, decimal ceoSalary)
        {
            this.TotalPaid += this.Salary;
            return this.Salary;
        }
    }
}
