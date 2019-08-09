using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class EnemyFactory
    {
        public List<BaseGatherer> Enemy = new List<BaseGatherer>
        {
            new Monk(50,12,15),
            new Rogue(50,10,20),
            new Mage(50,5,25),
       };
    }
}
