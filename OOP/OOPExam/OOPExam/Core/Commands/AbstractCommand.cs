namespace OOPExam.Core.Commands
{
    using Interfaces;

    public abstract class AbstractCommand : IExecutable
    {
        protected readonly IDatabase db;

        protected AbstractCommand(IDatabase db)
        {
            this.db = db;
        }

        public abstract string Execute();
    }
}
