using Capitalism.Core.Factories;
using Capitalism.Interfaces;
using Capitalism.Models.Employees;
using Capitalism.Models.OrganizationUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    public class CreateCompany : CommandAbstract
    {
        private string ceoFirstName;
        private string ceoLastName;
        private decimal salary;
        public CreateCompany(IDatabase db, string companyName, string ceoFirstName, string ceoLastName, decimal salary)
            : base(db, companyName)
        {
            this.ceoFirstName = ceoFirstName;
            this.ceoLastName = ceoLastName;
            this.salary = salary;
        }

        public override string Execute()
        {
            if (this.db.Companies.Any(c => c.Name == companyName))
            {
                throw new ArgumentException($"Company {companyName} alredy exists.");
            }
            IOrganizationUnit company = new Company(this.companyName);
            IEmployee ceo = EmployeeFactory.CreateEmployee(this.ceoFirstName, this.ceoLastName, "CEO", company, this.salary);

            this.db.AddCompany(company);
            company.AddEmployees(ceo);
            company.Head = ceo;

            return string.Empty;
        }
    }
}
