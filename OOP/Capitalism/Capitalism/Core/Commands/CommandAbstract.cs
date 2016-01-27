using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Commands
{
    using Interfaces;

    public abstract class CommandAbstract : IExecutable
    {
        protected IDatabase db;
        protected string companyName;

        protected CommandAbstract(IDatabase db, string companyName)
        {
            this.db = db;
            this.companyName = companyName;
        }

        public abstract string Execute();
    }
}
