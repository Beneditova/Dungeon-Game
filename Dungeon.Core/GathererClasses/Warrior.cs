using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Warrior : BaseGatherer
    {
        public Warrior(double health, int armor, int damage) : base(health, armor, damage)
        {
        }

        public override double Defend(double damage)
        {
            int blockDamageChance = rand.Next(1, 101);
            if (blockDamageChance<=30)
            {
                return base.Defend(0);
            }
            else
            {
                return base.Defend(damage);
            }
        }
    }
}
