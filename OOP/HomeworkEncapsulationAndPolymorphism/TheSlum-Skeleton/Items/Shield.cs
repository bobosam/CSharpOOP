﻿namespace TheSlum.Items
{
    public class Shield : Item
    {
        public Shield(string id, int healthEffect = 0, int defenseEffect = 50, int attackEffect = 0)
            : base(id, 0, 50, 0)
        {
        }
    }
}
