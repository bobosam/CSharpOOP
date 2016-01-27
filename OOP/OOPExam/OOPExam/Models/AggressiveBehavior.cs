namespace OOPExam.Models
{
    public class AggressiveBehavior :AbstractBehavior
    {
        private const int DamageCoefficientBahavior = 2;
        private const int HealthCoefficientBahavior = 0;
        private const int LossPerTurnBahavior = 5;

        public AggressiveBehavior()
            :base(DamageCoefficientBahavior, HealthCoefficientBahavior, LossPerTurnBahavior)
        {
        }
    }
}
