namespace OOPExam.Models
{
    public class PutridFartAttack : AbstractAttack
    {
        private const int DamageCoefficient = 1;
        private const int HealthCoefficient = 1;
        public PutridFartAttack()
            : base(DamageCoefficient, HealthCoefficient)
        {
        }
    }
}
