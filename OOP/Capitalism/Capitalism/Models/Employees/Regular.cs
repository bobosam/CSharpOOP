using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    public class Regular : Employee
    {
        private const decimal RegularSalaryFactor = 0m;
        public Regular(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, RegularSalaryFactor)
        {
        }
    }
}
