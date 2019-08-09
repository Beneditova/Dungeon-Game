using System;
using System.Threading;

namespace Dungeon.Core
{
    public class GameEngine
    {
        public BaseGatherer Hero { get; private set; }
        public BaseGatherer Enemy { get; private set; }
        public BaseGatherer Winner { get; private set; }

        private IFightNotifiations notifictions;

        public GameEngine(BaseGatherer hero, BaseGatherer enemy, IFightNotifiations notifictions)
        {
            Hero = hero;
            Enemy = enemy;
            this.notifictions = notifictions;
        }

        public void Fight()
        {
            BaseGatherer attacker, defender;
            attacker = Hero;
            defender = Enemy;

            while (attacker.IsAlive)
            {
                double attack = attacker.Attack();
                double damage = defender.Defend(attack);

                notifictions.FightReport(new FightReportArgs()
                {
                    GathererHero = attacker,
                    GathererEnemy = defender,
                    Attack = attack,
                    DamageRecieved = damage
                });

                Thread.Sleep(100);
                
                BaseGatherer temp;
                temp = attacker;
                attacker = defender;
                defender = temp;
            }

            if (Hero.IsAlive) Winner = Hero;
            else Winner = Enemy;
        }
    }
}
