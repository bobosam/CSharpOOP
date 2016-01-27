namespace TheSlum.Characters
{
    using System;
    using TheSlum.Interfaces;
    using TheSlum.Items;

    public abstract class AttackCharacter : Character, IAttack
    {
        private int attackPoints;

        public AttackCharacter(
            string id,
            int x,
            int y,
            int healthPoints,
            int defensePoints,
            Team team,
            int range,
            int attackPoints)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = attackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }

            set
            {
                if (0 >= value)
                {
                    throw new ArgumentOutOfRangeException("The attack points must be positive value");
                }

                this.attackPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }
                       
        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
    }
}
