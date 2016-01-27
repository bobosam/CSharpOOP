using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Interfaces
{
    public interface IOrganizationUnit
    {
        string Name { get; }

        IEnumerable<IOrganizationUnit> Subunits { get; }

        IEnumerable<IEmployee> Employees { get; }

        IEnumerable<IEmployee> AllEmployees { get; }

        IEmployee Head { get; set; }

        void AddSubunits(IOrganizationUnit subunit);
        void AddEmployees(IEmployee employee);

        void AddAllEmployees(IEmployee employee);
    }
}
