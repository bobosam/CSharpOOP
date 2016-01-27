using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Interfaces
{
    public interface IDatabase
    {
        IEnumerable<IOrganizationUnit> Companies { get; }
        void AddCompany(IOrganizationUnit company);
    }
}
