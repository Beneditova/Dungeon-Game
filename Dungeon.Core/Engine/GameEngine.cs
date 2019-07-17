using System;

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
            BaseGatherer hero, enemy;
            hero = Hero;
            enemy = Enemy;

            while (hero.IsAlive)
            {
                int attack = hero.Attack();
                int damage = enemy.Defend(attack);

                notifictions.FightReport(new FightReportArgs()
                {
                    Hero = hero,
                    Enemy = enemy,
                    Attack = attack,
                    DamageRecieved = damage
                });

                BaseGatherer temp;
                temp = hero;
                hero = enemy;
                enemy = temp;
            }

            if (Hero.IsAlive) Winner = Hero;
            else Winner = Enemy;
        }
    }
}
