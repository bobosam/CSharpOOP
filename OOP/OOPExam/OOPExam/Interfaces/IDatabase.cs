namespace OOPExam.Interfaces
{
    using System.Collections.Generic;

    public interface IDatabase
    {
        IEnumerable<IBlob> AllBlobs { get; }

        void AddBlob(IBlob blob);
    }
}
