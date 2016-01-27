using SampleExamEmpires.Contracts;
using SampleExamEmpires.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models.Buildings
{
   public class Barracks : Building
    {
        private const string UnitType = "Swordsman";
        private const int UnitCicleLenth = 4;
        private const ResourceType BarracsResourceType = ResourceType.Steel;
        private const int ResourceCicleLength = 3;
        private const int ResourceQuantity = 10;

        public Barracks(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            :base(
                 UnitType,
                 UnitCicleLenth,
                 BarracsResourceType,
                 ResourceCicleLength,
                 ResourceQuantity,
                 unitFactory,
                 resourceFactory)
        {
        }
    }
}
