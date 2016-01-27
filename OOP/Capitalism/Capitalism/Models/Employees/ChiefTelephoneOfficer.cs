using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    public class ChiefTelephoneOfficer : Employee
    {
        private const decimal ChiefTelephoneOfficerSalaryFactor = -0.02m;
        public ChiefTelephoneOfficer(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, ChiefTelephoneOfficerSalaryFactor)
        {
        }
    }
}
