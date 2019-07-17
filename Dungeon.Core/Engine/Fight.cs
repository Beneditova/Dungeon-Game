using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void FightHappend()
        {
            var hero = new Warrior(100, 15, 20);
            var enemy = new Monk(100, 7, 30);

            var engine = new GameEngine(hero, enemy, _fightNotifiations);
            Console.WriteLine("The fierce battle begins!");
          
            engine.Fight();

            Console.WriteLine("Winner is: " + engine.Winner);
        }
    }
}
