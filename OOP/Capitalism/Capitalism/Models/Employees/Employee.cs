using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    using Interfaces;
    public abstract class Employee : IEmployee
    {
        public Employee(
            string firsrName,
            string lastName,
            IOrganizationUnit inUnit,
            decimal salaryFactor)
        {
            this.FirstName = firsrName;
            this.LastName = LastName;
            this.InUnit = inUnit;
            this.SalaryFactor = salaryFactor;
        }
        public string FirstName { get; }

        public IOrganizationUnit InUnit { get; }

        public string LastName { get; }

        public decimal SalaryFactor { get; }

        public decimal TotalPaid { get; set; }

        public virtual decimal RecieveSalary(decimal percent, decimal ceoSalary)
        {
            percent += this.SalaryFactor;
            decimal toPay = ceoSalary * percent;
            this.TotalPaid += toPay;

            return toPay;
        }
    }
}
