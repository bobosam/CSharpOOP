using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism
{
    using Core;
    using Core.Commands;
    using Core.Engines;
    using Interfaces;

    public class CapitalismAplication
    {
        static void Main(string[] args)
        {
            IDatabase db = new Database();
            IEngine engine = new ConsoleEngin(db);
            engine.Run();
        }
    }
}
