namespace OOPExam.Interfaces
{
    public interface IBehavior : IAggressiveBehavior, IInflatedBehavior
    {
        bool IsTrigered { get; set; }

        int LossPerTurn { get; }
    }
}
