using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Core.Factories
{
    using Contracts;
    using Models.Buildings;
    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            switch (buildingType)
            {
                case "archery":
                    return new Archery(unitFactory, resourceFactory);
                case "barracks":
                    return new Barracks(unitFactory, resourceFactory);
                default:
                    throw new ArgumentException("Unknoun building type!");

            }
        }
    }
}
