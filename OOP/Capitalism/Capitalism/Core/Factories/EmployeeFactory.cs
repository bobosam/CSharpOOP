using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Factories
{
    using Interfaces;
    using Models.Employees;
    public static class EmployeeFactory
    {
        public static IEmployee CreateEmployee (
            string firstName,
            string lastName,
            string position,
            IOrganizationUnit inUnit,
            decimal salary = 0
            )
        {
            switch (position)
            {
                case "CEO":
                    return new CEO(firstName, lastName, inUnit, salary) ;
                case "Manager":
                    return new Manager(firstName, lastName, inUnit);
                case "Regular":
                    return new Regular(firstName, lastName, inUnit);
                case "ChiefTelephoneOfficer":
                    return new ChiefTelephoneOfficer(firstName, lastName, inUnit);
                case "CleaningLady":
                    return new CleaningLady(firstName, lastName, inUnit);
                case "Salesman":
                    return new Salesman(firstName, lastName, inUnit);
                case "Accountant":
                    return new Accountant(firstName, lastName, inUnit);
                default:
                    throw new ArgumentException("Unknoun type employee!");
            }
        }
    }
}
