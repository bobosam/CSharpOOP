using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models.Buildings
{
    using Contracts;
    using Enum;

    public abstract class Building : IBuilding
    {
        private int ciclesCount = 0;
        private string unitType;
        private int unitCicleLength;
        private ResourceType resourceType;
        private int resourceCicleLength;
        private IUnitFactory unitFactory;
        private IResourceFactory resourceFactory;
        private int quantity;

        public Building(
            string unitType,
            int unitCicleLength,
            ResourceType resourceType,
            int resourceCicleLength,
            int quantity,
            IUnitFactory unitFactory,
            IResourceFactory resourceFactory)
        {
            this.unitType = unitType;
            this.unitCicleLength = unitCicleLength;
            this.resourceType = resourceType;
            this.resourceCicleLength = resourceCicleLength;
            this.quantity = quantity;
            this.unitFactory = unitFactory;
            this.resourceFactory = resourceFactory;
        }

        public bool CanProduceUnit
        {
            get
            {
                int ciclesCounter = this.ciclesCount - 1;
                bool check = (ciclesCounter % unitCicleLength == 0) && (0 < ciclesCounter);

                return check;
            }
        }

        public bool CanResourceProduce
        {
            get
            {
                int ciclesCounter = this.ciclesCount - 1;
                bool check = (ciclesCounter % resourceCicleLength == 0) && (0 < ciclesCounter);

                return check;
            }
        }

        public IResource ProduceResource()
        {
            IResource resource = this.resourceFactory.CreateResource(this.resourceType, this.quantity);

            return resource;
        }

        public IUnit ProduceUnit()
        {
            IUnit unit = this.unitFactory.CreateUnit(this.unitType);

            return unit;
        }

        public void Update()
        {
            ciclesCount++; ;
        }

        public override string ToString()
        {
            int ciclesCounter = this.ciclesCount - 1;
            int turnsUntilResources = this.resourceCicleLength - (ciclesCounter % resourceCicleLength);
            int turnsUntilUnit = this.unitCicleLength - (ciclesCounter % unitCicleLength);
            var unitType = this.unitType;
            var resourceType = this.resourceType;
            var buildingType = this.GetType().Name;
            var viewBuilding = string.Format($"--{buildingType}: {ciclesCounter} turns ({turnsUntilUnit} turns until {unitType}, {turnsUntilResources} turns until {resourceType})");
            return viewBuilding;
        }
    }
}
