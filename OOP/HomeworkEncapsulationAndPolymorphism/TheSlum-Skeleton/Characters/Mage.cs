namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Mage : AttackCharacter, IAttack
    {
        public Mage(
            string id,
            int x,
            int y,
            Team team,
            int healthPoints = 150,
            int defensePoints = 50,
            int range = 5,
            int attackPoints = 300)
            : base(id, x, y, 150, 50, team, 5, 300)
        {
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.Last(t => t.Team != this.Team && t.IsAlive);

            return target;
        }
    }
}
