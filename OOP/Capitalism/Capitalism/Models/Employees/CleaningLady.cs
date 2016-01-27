using Capitalism.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.Employees
{
   public class CleaningLady : Employee
    {
        private const decimal CleaningLadySalaryFactor = -0.02m;
        public CleaningLady(string firstName, string lastName, IOrganizationUnit inUnit)
            : base(firstName, lastName, inUnit, CleaningLadySalaryFactor)
        {
        }
    }
}
