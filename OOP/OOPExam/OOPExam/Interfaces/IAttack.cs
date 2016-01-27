using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.Interfaces
{
    public interface IAttack :IAttackDamage, IAttackHealth
    {
        bool IsTrigered { get; set; }

        int LossPerTurn { get; }
    }
}
