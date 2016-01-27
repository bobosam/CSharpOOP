namespace OOPExam.Models
{
    using Interfaces;
    public abstract class AbstractBehavior : IBehavior
    {
        protected AbstractBehavior(
            int damageCoefficient,
            int healthCoefficient,
            int lossPerTurn,
            bool isTrigered = false)

        {
            this.DamageCoefficient = damageCoefficient;
            this.HealthCoefficient = healthCoefficient;
            this.IsTrigered = isTrigered;
            this.LossPerTurn = lossPerTurn;
        }

        public int DamageCoefficient { get; }

        public int HealthCoefficient { get; }

        public bool IsTrigered { get; set; }

        public int LossPerTurn { get; }
    }
}
