using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.OrganizationUnit
{
    using Interfaces;

    public class Company : IOrganizationUnit
    {
        private IList<IOrganizationUnit> subunits;
        private IList<IEmployee> employees;
        private IList<IEmployee> allEmployees;

        public Company(string name)
        {
            this.subunits = new List<IOrganizationUnit>();
            this.employees = new List<IEmployee>();
            this.Name = name;
            this.allEmployees = new List<IEmployee>();
        }

        public IEnumerable<IEmployee> Employees
        {
            get
            {
                return this.employees;
            }
        }

        public IEnumerable<IEmployee> AllEmployees
        {
            get
            {
                return this.allEmployees;
            }
        }

        public IEmployee Head { get; set; }

        public string Name { get; }

        public IEnumerable<IOrganizationUnit> Subunits
        {
            get
            {
                return this.subunits;
            }
        }

        public void AddSubunits(IOrganizationUnit subunit)
        {
            this.subunits.Add(subunit);
        }

        public void AddEmployees(IEmployee employee)
        {
            this.employees.Add(employee);
        }

        public void AddAllEmployees(IEmployee employee)
        {
            this.allEmployees.Add(employee);
        }
    }
}
