using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Core.Factories
{
    using Contracts;
    using Models.Units;
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch(unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unknoun type");
            }
        }
    }
}
