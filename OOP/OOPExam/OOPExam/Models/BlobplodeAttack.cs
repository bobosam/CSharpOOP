namespace OOPExam.Models
{
    class BlobplodeAttack : AbstractAttack
    {
        private const int DamageCoefficient = 2;
        private const int HealthCoefficient = 2;
        public BlobplodeAttack()
            : base(DamageCoefficient, HealthCoefficient)
        {
        }
    }
}
