namespace OOPExam.Core.Commands
{
    using Interfaces;

    public class PassCommand : AbstractCommand
    {
        public PassCommand(IDatabase db)
            : base(db)
        {
        }

        public override string Execute()
        {
            return string.Empty;
        }
    }
}
