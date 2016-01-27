using OOPExam.Interfaces;
using System;

namespace OOPExam.Core.Commands
{
    public class AttackComand : AbstractCommand
    {
        private string attakerName;
        private string targetName;

        public AttackComand(IDatabase db, string attakerName, string targetName)
            :base(db)
        {
            this.attakerName = attakerName;
            this.targetName = targetName;
        }

        public override string Execute()
        {
            IBlob attaker = null;
            IBlob target = null;
            foreach (var blob in db.AllBlobs)
            {
                if (this.attakerName == blob.Name)
                {
                    attaker = blob;
                }
            }

            foreach (var blob in db.AllBlobs)
            {
                if (this.targetName == blob.Name)
                {
                    target = blob;
                }
            }

            if (null == attaker || null == target)
            {
                throw new ArgumentNullException("blob missing!");
            }

            target.Health -= attaker.Damage;
            if (target.Health < target.InitialDamage/2)
            {

            }
            throw new NotImplementedException();
        }
    }
}
