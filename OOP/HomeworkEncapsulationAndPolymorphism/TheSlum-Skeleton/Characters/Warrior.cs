namespace TheSlum.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;
       
    public class Warrior : AttackCharacter, IAttack
    {
        public Warrior(
            string id,
            int x,
            int y,
            Team team,
            int healthPoints = 200,
            int defensePoints = 100,            
            int range = 2,
            int attackPoints = 150)
            : base(id, x, y, 200, 100, team, 2, 150)
        {
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.First(t => t.Team != this.Team && t.IsAlive);

            return target;
        }
    }
}
