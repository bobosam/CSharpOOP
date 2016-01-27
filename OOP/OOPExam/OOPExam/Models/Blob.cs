namespace OOPExam.Models
{
    using Interfaces;

    public class Blob : IBlob
    {
        public Blob(string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.Behavior = behavior;
            this.Attack = Attack;
            this.InitialDamage = damage;
            this.InitialHealth = health;
        }

        public IAttack Attack { get; }

        public IBehavior Behavior { get; }

        public int Damage { get; set; }

        public int Health { get; set; }

        public string Name { get; }

        public int InitialDamage { get; }

        public int InitialHealth { get; }
    }
}
