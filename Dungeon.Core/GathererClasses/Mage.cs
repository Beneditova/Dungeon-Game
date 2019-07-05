using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Mage : BaseGatherer
    {
        public Mage(double health, double armor, double damage) : base(health, armor, damage)
        {
        }

        public override double Attack()
        {
            int tripleAttackChance = rand.Next(1, 101);
            if (tripleAttackChance<=30)
            {
                return base.Attack() * 3;
            }
            else return base.Attack();
        }
    }
}
