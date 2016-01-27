
namespace OOPExam.Core.Factories
{
    using Interfaces;
    using Models;

    public static class BlobFactory
    {
        public static IBlob Create (string name, int health, int damage, IBehavior behavior, IAttack attack)
        {
            return new Blob(name, health, damage, behavior, attack);
        }
    }
}
