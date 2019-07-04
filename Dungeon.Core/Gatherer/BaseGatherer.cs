using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class BaseGatherer
    {
        private int health;
        private int damage;

        public BaseGatherer(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public int Health
        {
            get { return health; }
            private set { health = value; }
        }

        public int Damage
        {
            get { return damage; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Damage must be greater than zero.");
                damage = value;
            }
        }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public virtual int Attack()
        {
            return Damage;
        }

        public virtual int Defend(int damage)
        {
            return Health - damage;
        }
    }
}
