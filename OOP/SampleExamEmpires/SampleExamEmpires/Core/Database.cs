namespace SampleExamEmpires.Core
{
    using System;
    using System.Collections.Generic;

    using Contracts;
    using Enum;
    public class Database : IDatabase
    {
        private ICollection<IBuilding> buildings = new List<IBuilding>();
        //private IDictionary<ResourceType, int> resource;
        //private ICollection<KeyValuePair<string, int>> units = new Dictionary<string, int>();

        public Database()
        {
            this.Resources = new Dictionary<ResourceType, int>();
            this.Units = new Dictionary<string, int>();
            this.InitResources();
        }

        private void InitResources()
        {
            var resourceTypes = Enum.GetValues(typeof(ResourceType));

            foreach (ResourceType resourceType in resourceTypes)
            {
                this.Resources.Add(resourceType, 0);
            }
        }

        public IEnumerable<IBuilding> Buildings
        {
            get
            {
                return this.buildings;
            }
        }

        public IDictionary<ResourceType, int> Resources { get; }

        public IDictionary<string, int> Units { get; }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            var unitType = unit.GetType().Name;
            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType, 0);
            }

            this.Units[unitType]++;
        }
        
        public void AddBuilding(IBuilding building)
        {
            if (null == building)
            {
                throw new ArgumentNullException(nameof(building));
            }

            this.buildings.Add(building);
        }
    }
}
