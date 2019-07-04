using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class FightReportArgs
    {
        public BaseGatherer Hero { get; set; }
        public BaseGatherer Enemy { get; set; }

        public int Attack { get; set; }
        public int DamageRecieved { get; set; }
    }
}
