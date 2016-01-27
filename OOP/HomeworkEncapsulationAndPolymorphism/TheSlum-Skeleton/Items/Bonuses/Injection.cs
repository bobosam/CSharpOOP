namespace TheSlum.Items.Bonuses
{
    public class Injection : Bonus
    {
        public Injection(string id, int healthEffect = 200, int defenseEffect = 0, int attackEffect = 0)
            : base(id, 200, 0, 0)
        {
            this.Countdown = 3;
            this.Timeout = 3;
            this.HasTimedOut = false;
        }
    }
}
