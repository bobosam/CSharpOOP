namespace OOPExam.Models
{
    using Interfaces;

    public abstract class AbstractAttack : IAttack
    {
        protected AbstractAttack(int attackDamageCoefficient, int attackHealthCoefficient)
        {
            this.AttakDamageCoefficient = attackDamageCoefficient;
            this.AttakHealthCoefficient = attackHealthCoefficient;

        }

        public int AttakDamageCoefficient { get; }
        
        public int AttakHealthCoefficient { get; }

        public bool IsTrigered { get; set; }

        public int LossPerTurn { get; }

    }
}
