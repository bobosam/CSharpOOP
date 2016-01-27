using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models.Buildings
{
    using Contracts;
    using Enum;
    class Archery : Building
    {
        private const string UnitType = "Archer";
        private const int UnitCicleLenth = 3;
        private const ResourceType ArcheryResourceType = ResourceType.Gold;
        private const int ResourceCicleLength = 2;
        private const int ResourceQuantity = 5;

        public Archery(IUnitFactory unitFactory, IResourceFactory resourceFactory)
            :base(
                 UnitType,
                 UnitCicleLenth,
                 ArcheryResourceType,
                 ResourceCicleLength,
                 ResourceQuantity,
                 unitFactory,
                 resourceFactory)
        {
        }
    }
}
