namespace OOPExam.Core.Factories
{
    using System;

    using Interfaces;
    using Models;

    public static class BehaviorFactory
    {
        public static IBehavior Create(string behaviorType)
        {
            switch (behaviorType)
            {
                case "Inflated":
                    IBehavior behavior = new InflatedBehavior();
                    return behavior;
                case "Aggressive":
                    behavior = new AggressiveBehavior();
                    return behavior;
                default:
                    throw new NotImplementedException("Unknoun type behavior!");
            }
        }
    }
}
