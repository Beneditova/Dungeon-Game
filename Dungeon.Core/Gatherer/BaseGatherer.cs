using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public abstract class BaseGatherer
    {
        protected Random rand = new Random();

        private double _health=20;
        private double _damage=20;
        private double _armor=20;

        public BaseGatherer(double health, double armor, double damage)
        {
            this.Health = health;
            this.Armor = armor;
            this.Damage = damage;
        }

        public double Health
        {
            get { return _health; }
            set
            {
                if (_health > 0) 
                {
                    _health = value;
                }
                else throw new ArgumentOutOfRangeException("Cannot create a dead hero!");
            }
        }

        public double Armor
        {
            get { return _armor; }
            private set
            {
                if (value > 0) 
                {
                    _armor = value;
                }
                else throw new ArgumentOutOfRangeException("Armor must be greater than zero.");

            }
        }

        public double Damage
        {
            get { return _damage; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Damage must be greater than zero.");
                }
                   
                _damage = value;
            }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public bool IsDead
        {
            get
            {
                return Health == 0;
            }
        }

        public virtual double Attack()
        {
            return Damage;
        }

        public virtual double Defend(double damage)
        {
            if (damage < 0) throw new ArgumentOutOfRangeException("Damage cannot be negative!");
            
            double damageReduced = damage - Armor;

            if (damageReduced < 0) return 0;

            Health = Health - damageReduced;
            return damageReduced;
        }
    }
}

