namespace OOPExam.Core.Factories
{
    using System;

    using Interfaces;
    using Models;

    public static class AttackFactory
    {
        public static IAttack Create(string attackType)
        {
            switch (attackType)
            {
                case "PutridFart":
                    IAttack attack = new PutridFartAttack();
                    return attack;
                case "Blobplode":
                    attack = new BlobplodeAttack();
                    return attack;
                default:
                    throw new NotImplementedException("Unknoun type attack!");
            }
        }
    }
}
