namespace OOPExam.Models
{
    public class InflatedBehavior : AbstractBehavior
    {
        private const int DamageCoefficientBahavior = 1;
        private const int HealthCoefficientBahavior = 50;
        private const int LossPerTurnBahavior = 10;

        public InflatedBehavior()
            :base(DamageCoefficientBahavior, HealthCoefficientBahavior, LossPerTurnBahavior)
        {
        }
    }
}
