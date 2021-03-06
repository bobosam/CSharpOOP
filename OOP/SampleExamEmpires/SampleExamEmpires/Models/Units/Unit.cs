﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Models.Units
{
    using SampleExamEmpires.Contracts;
    public abstract class Unit : IUnit
    {
        protected Unit(int attackDamage, int health)
        {
            this.AttackDamage = attackDamage;
            this.Health = health;  
        }

        public int AttackDamage { get; }

        public int Health { get; }
    }
}
