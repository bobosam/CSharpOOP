using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    public class Manager : Employee
    {
        private const decimal ManagerSalaryFactor = 0.01m;
        public Manager(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, ManagerSalaryFactor)
        {
        }
    }
}
