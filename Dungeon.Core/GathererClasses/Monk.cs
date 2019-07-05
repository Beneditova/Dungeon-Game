using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Monk : BaseGatherer
    {
        public Monk(double health, double armor, double damage) : base(health, armor, damage)
        {
        }

        public override double Defend(double damage)
        {
            int restoreHealthChance = rand.Next(1, 101);
            if (restoreHealthChance<=30)
            {
                double restoredHeath =base.Health*0.05;
                base.Health += restoredHeath;
            }
            return base.Defend(damage);
        }
    }
}
