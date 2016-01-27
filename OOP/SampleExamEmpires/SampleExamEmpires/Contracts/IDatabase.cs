using SampleExamEmpires.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Contracts
{
    public interface IDatabase
    {
        IEnumerable<IBuilding> Buildings { get; }

        void AddBuilding(IBuilding building);

        void AddUnit(IUnit unit);


        IDictionary<ResourceType, int> Resources { get; }
        IDictionary<string, int> Units { get; }
    }
}
