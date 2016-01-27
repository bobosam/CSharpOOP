﻿namespace Problem02.WorkingWithAbstraction.Characters
{
    using Problem02.WorkingWithAbstraction.Interfaces;

    public abstract class Character : IAttack
    {
        public Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }

        public int Health { get; set; }

        public int Mana { get; set; }

        public int Damage { get; set; }

        public abstract void Attack(Character target);
    }
}
