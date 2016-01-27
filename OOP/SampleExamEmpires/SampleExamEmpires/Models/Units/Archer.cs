using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models.Units
{
    using SampleExamEmpires.Contracts;
    public class Archer : Unit
    {
        private const int ArcherAttack = 7;
        private const int ArcherHealth = 25;

        public Archer()
            : base (ArcherAttack, ArcherHealth)
        {
        }
    }
}
