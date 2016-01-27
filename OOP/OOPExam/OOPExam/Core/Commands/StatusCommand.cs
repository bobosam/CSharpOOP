namespace OOPExam.Core.Commands
{
    using System.Text;

    using OOPExam.Interfaces;

    public class StatusCommand : AbstractCommand
    {
        public StatusCommand(IDatabase db)
            : base(db)
        {
        }

        public override string Execute()
        {
            StringBuilder viewStatus = new StringBuilder();
            foreach (var blob in db.AllBlobs)
            {
                if (blob.Health <= 0)
                {
                    viewStatus.AppendLine(string.Format($"Blob {blob.Name} KILLED"));
                }
                else
                {
                    viewStatus.AppendLine(string.Format($"Blob {blob.Name}: {blob.Health} HP, {blob.Damage} Damage"));
                }
            }

            return viewStatus.ToString().Trim();
        }
    }
}
