namespace OOPExam.Core
{
    using System.Collections.Generic;

    using Interfaces;

    public class Database : IDatabase
    {
        private IList<IBlob> allBlobs;

        public Database()
        {
            this.allBlobs = new List<IBlob>();
        }
        public IEnumerable<IBlob> AllBlobs
        {
            get
            {
                return this.allBlobs;
            }
        }

        public void AddBlob(IBlob blob)
        {
            this.allBlobs.Add(blob);
        }
    }
}
