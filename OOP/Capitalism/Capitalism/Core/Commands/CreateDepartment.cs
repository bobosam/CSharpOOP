using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    using Interfaces;
    using Models.Employees;
    using Models.OrganizationUnit;
    public class CreateDepartment : CommandAbstract
    {
        private string departmentName;
        private string menagerFirstName;
        private string menagerLastName;
        private string mainDepartmentName;
        public CreateDepartment(
            IDatabase db,
            string companyName,
            string departmentName,
            string menagerFirstName,
            string menagerLastName,
            string mainDepartmentName = null)
            : base(db, companyName)
        {
            this.departmentName = departmentName;
            this.menagerFirstName = menagerFirstName;
            this.menagerLastName = menagerLastName;
            this.mainDepartmentName = mainDepartmentName;
        }

        public override string Execute()
        {
            IOrganizationUnit company = this.db.Companies.FirstOrDefault(c => c.Name == companyName);
            if (company == null)
            {
                throw new ArgumentException($"Company {companyName} does not exist");
            }

            IOrganizationUnit department = company.Subunits.FirstOrDefault(d => d.Name == this.departmentName);
            if (department != null)
            {
                throw new ArgumentException($"Department {departmentName} already exists in {companyName}");
            }

            IOrganizationUnit mainDepartment = company.Subunits.FirstOrDefault(md => md.Name == this.mainDepartmentName);
            IEmployee manager = null;
            if (this.mainDepartmentName == null)
            {
                manager = company.Employees.FirstOrDefault(m => m.FirstName == this.menagerFirstName && m.LastName == this.menagerLastName);
            }
            else
            {
                if (mainDepartment == null)
                {
                    throw new ArgumentException($"There is no department {this.mainDepartmentName} in {this.companyName}");
                }
                manager = mainDepartment.Employees.FirstOrDefault(m => m.FirstName == this.menagerFirstName && m.LastName == this.menagerLastName);
            }

            if (!(manager is Manager))
            {
                throw new ArgumentException($"{this.menagerFirstName} {this.menagerLastName} is not a manager(real position: {manager.GetType().Name}");
            }

            IOrganizationUnit newDepartment = new Department(this.departmentName);
            newDepartment.Head = manager;
            if (mainDepartment == null)
            {
                company.AddSubunits(newDepartment);
            }
            else
            {
                mainDepartment.AddSubunits(newDepartment);
            }

            return string.Empty;
        }

    }
}
