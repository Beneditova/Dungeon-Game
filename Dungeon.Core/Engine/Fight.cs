using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class Fight
    {
        private IFightNotifiations _fightNotifiations;

        public Fight(IFightNotifiations fightNotifiations)
        {
            _fightNotifiations = fightNotifiations;
        }

        public void FightHappend(BaseGatherer enemy)
        {
            var engine = new GameEngine(GathererSettings.Instance.GetHeroType(), enemy, _fightNotifiations);

            Console.WriteLine("The fierce battle begins!");
          
            engine.Fight();
            Thread.Sleep(1000);
            Console.WriteLine("Winner is: " + engine.Winner);
            Thread.Sleep(1000);
        }
    }
}
