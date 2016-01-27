using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Models.OrganizationUnit
{
    using Interfaces;

    public class Department : IOrganizationUnit
    {
        private IList<IOrganizationUnit> subunits;
        private IList<IEmployee> employees;

        public Department(string name)
        {
            this.subunits = new List<IOrganizationUnit>();
            this.employees = new List<IEmployee>();
            this.Name = name;
        }

        public IEnumerable<IEmployee> Employees
        {
            get
            {
                return this.employees;
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

        public IEnumerable<IEmployee> AllEmployees
        {
            get
            {
                throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
