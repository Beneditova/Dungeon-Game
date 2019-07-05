using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public abstract class BaseGatherer
    {
        static protected Random rand = new Random();

        private double health;
        private double damage;
        private double armor;

        public BaseGatherer(double health, double armor, double damage)
        {
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public double Health
        {
            get { return health; }
            set
            {
                if (health > 0) 
                {
                    health = value;
                }
                else throw new ArgumentOutOfRangeException("Cannot create a dead hero!");
            }
        }

        public double Armor
        {
            get { return armor; }
            private set
            {
                if (value > 0) 
                {
                    armor = value;
                }
                else throw new ArgumentOutOfRangeException("Armor must be greater than zero.");

            }
        }

        public double Damage
        {
            get { return damage; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Damage must be greater than zero.");
                }
                   
                damage = value;
            }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public virtual double Attack()
        {
            return Damage;
        }

        public virtual double Defend(double damage)
        {
            if (damage < 0) throw new ArgumentOutOfRangeException("Damage cannot be negative!");

            double damageReduced = damage - Armor;
            Health = Health - damageReduced;

            if (damageReduced < 0)
            {
                return 0;
            }
            else return damageReduced;
        }
    }
}
