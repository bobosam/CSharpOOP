using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    public class Accountant : Employee
    {
        private const decimal AccountantSalaryFactor = 0m;
        public Accountant(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, AccountantSalaryFactor)
        {
        }
    }
}
