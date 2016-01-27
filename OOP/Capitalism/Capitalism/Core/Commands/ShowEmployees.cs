using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    using Interfaces;

    public class ShowEmployees : CommandAbstract
    {
        public ShowEmployees(IDatabase db, string companyName)
            : base(db, companyName)
        {
        }

        public override string Execute()
        {
            throw new NotImplementedException();
        }
    }
}
