namespace OOPExam.Interfaces
{
    public interface IBlob : IAttaker, IDestroyable
    {
        string Name { get; }

        IAttack Attack { get; }

        IBehavior Behavior { get; }
    }
}
