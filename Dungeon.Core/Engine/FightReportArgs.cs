using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class FightReportArgs
    {
        public BaseGatherer GathererHero { get; set; }
        public BaseGatherer GathererEnemy { get; set; }

        public double Attack { get; set; }
        public double DamageRecieved { get; set; }
    }
}
