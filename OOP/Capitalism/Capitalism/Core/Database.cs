using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core
{
    using Interfaces;

    public class Database : IDatabase
    {
        private IList<IOrganizationUnit> companies;

        public Database()
        {
            this.companies = new List<IOrganizationUnit>();
        }

        public IEnumerable<IOrganizationUnit> Companies
        {
            get
            {
                return this.companies;
            }
        }

        public void AddCompany(IOrganizationUnit company)
        {
            this.companies.Add(company);
        }
    }
}
