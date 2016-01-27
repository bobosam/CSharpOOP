namespace TheSlum.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;
    using TheSlum.Items;

    public class Healer : Character, IHeal
    {
        private int healingPoints;

        public Healer(
            string id,
            int x,
            int y,
            Team team,
            int healthPoints = 75,
            int defensePoints = 50,           
            int range = 6,
            int healingPoints = 60)
            : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }

            set
            {
                if (0 >= value)
                {
                    throw new ArgumentOutOfRangeException("The healing points must be positive value");
                }

                this.healingPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var ourTeam = targetsList.Where(t => t.Team == this.Team && t.IsAlive);
            var minHealth = ourTeam.Min(t => t.HealthPoints);
            var target = ourTeam.First(t => t.HealthPoints == minHealth);

            return target;
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
    }
}
