using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    using Interfaces;
    using Models.Employees;
    public class PaySalaries : CommandAbstract
    {
        private CEO ceo;
        private StringBuilder output;

        public PaySalaries(IDatabase db,
            string companyName
            ) : base(db, companyName)
        {
            this.output = new StringBuilder();
        }

        public override string Execute()
        {
            IOrganizationUnit company = this.db.Companies.FirstOrDefault(c => c.Name == this.companyName);
            if (company == null)
            {
                throw new ArgumentException(
                    string.Format("Company {0} does not exist", this.companyName));
            }
            ceo = (CEO)company.Head;
            this.Pay(company, 0, 0);
            return this.output.ToString();
        }

        private decimal Pay(
            IOrganizationUnit unit,
            decimal paid,
            int depth)
        {

            foreach (var dep in unit.Subunits)
            {
                paid += this.Pay(dep, 0, depth + 1);
            }

            foreach (var emp in unit.Employees)
            {
                decimal percents = (15 - depth) * 0.01m;
                paid += emp.RecieveSalary(percents, this.ceo.Salary);
            }

            this.output.Insert(0,
                    string.Format("{0}{1} ({2:f2})\n",
                        new String(' ', depth * 4),
                        unit.Name,
                        paid
                        )
                    );

            return paid;
        }
    }
}
