using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Rogue : BaseGatherer
    {
        public Rogue(double health, double armor, double damage) : base(health, armor, damage)
        {
        }

        public override double Attack()
        {
            int doubleAttackChance = rand.Next(1, 101);
            if (doubleAttackChance<=40)
            {
                return base.Attack()*2;
            }
            return base.Attack();
        }
    }
}
