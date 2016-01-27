using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    using Factories;
    using Interfaces;

    public class CreateEmployee : CommandAbstract
    {
        private string firstName;
        private string lastName;
        private string position;
        private string departmentName;

        public CreateEmployee(
            IDatabase db,
            string firstName,
            string lastName,
            string position,
            string companyName,
            string departmentName)
            : base(db, companyName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.departmentName = departmentName;
        }

        public override string Execute()
        {
            IOrganizationUnit company = this.db.Companies.FirstOrDefault(c => c.Name == this.companyName);
            if (null == company)
            {
                throw new ArgumentException($"Company {this.companyName} does not exist");
            }

            IEmployee employee = company.AllEmployees.FirstOrDefault(e => e.FirstName == this.firstName && e.LastName == this.lastName);
            if (null != employee)
            {
                throw new ArgumentException($"Employee {this.firstName} {this.lastName} already exists in {company.Name} (in department {employee.InUnit.Name})");
            }

            IOrganizationUnit inUnit = company;
            if (this.departmentName != null)
            {
                inUnit = company.Subunits.FirstOrDefault(d => d.Name == this.departmentName);
            }

            IEmployee newEmployee = EmployeeFactory.CreateEmployee(this.firstName, this.lastName, this.position, inUnit);
            company.AddAllEmployees(newEmployee);
            inUnit.AddEmployees(newEmployee);

            return string.Empty;
        }
    }
}
