using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
    public class Salesman : Employee
    {
        private const decimal SalesmanSalaryFactor = 0.015m;
        public Salesman(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, SalesmanSalaryFactor)
        {
        }
    }
}
