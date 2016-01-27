namespace OOPExam.Core.Commands
{
    using Factories;
    using Interfaces;
    public class CreateCommand : AbstractCommand
    {
        //string name, int health, int damage, IBehavior behavior, IAttack attack
        private string name;
        private int health;
        private int damage;
        private string behaviorType;
        private string attackType;

        public CreateCommand(IDatabase db,string name, int health, int damage, string behaviorType, string attackType)
            :base (db)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.behaviorType = behaviorType;
            this.attackType = attackType;
        }
        public override string Execute()
        {
            IBehavior behavior = BehaviorFactory.Create(this.behaviorType);
            IAttack attack = AttackFactory.Create(this.attackType);
            IBlob blob = BlobFactory.Create(this.name, this.health, this.damage, behavior, attack);
            this.db.AddBlob(blob);

            // string viewBlob = string.Format($"Blob {this.name}: {this.health} HP, {this.damage} Damage");

            return string.Empty; // viewBlob;
        }
    }
}
