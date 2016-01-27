namespace TheSlum.Items.Bonuses
{
    public class Pill : Bonus
    {
        public Pill(string id, int healthEffect = 0, int defenseEffect = 0, int attackEffect = 100)
            : base(id, 0, 0, 100)
        {
            this.Countdown = 1;
            this.Timeout = 1;
            this.HasTimedOut = false;
        }
    }
}
