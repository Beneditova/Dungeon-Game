using System;

namespace Dungeon.Core
{
    public class GathererManager
    {
        private int x = 0, y = 0;
        private int maxX = one.Location[one.Current].Scene.GetLength(0), maxY = one.Location[one.Current].Scene.GetLength(1);

        static LocationCollector one = new LocationCollector();

         private readonly IFightNotifiations _fightNotifiations;
         private readonly ILocationEventHandler _locationEventHandler;

        public GathererManager(IFightNotifiations fightNotifiations,  ILocationEventHandler locationEventHandler)
        {
            this._fightNotifiations = fightNotifiations;
            this._locationEventHandler = locationEventHandler;
        }


        public void MoveRight()
        {
            if (!y.Equals(maxY - 1))
            {
                Action(x, y + 1);
               
                if (one.Location[one.Current].Scene[x, y + 1] != LocationObject.Terrain)
                {
                    y++;
                }
            }
           
            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = one,
                X = x,
                Y = y
            });
          
        }

        public void MoveLeft()
        {
            if (!y.Equals(0))
            {
                Action(x, y - 1);
               
                if (one.Location[one.Current].Scene[x, y - 1] != LocationObject.Terrain)
                {
                    y--;
                }
            }
           
            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = one,
                X = x,
                Y = y
            });
        }

        public void MoveUp()
        {
            if (!x.Equals(0))
            {
                Action(x - 1, y);

                if (one.Location[one.Current].Scene[x - 1, y] != LocationObject.Terrain)
                {
                   x--;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = one,
                X = x,
                Y = y
            });
        }

        public void MoveDown()
        {
            if (x + 1 < maxX)
            {
              
                Action(x + 1, y);

                if (one.Location[one.Current].Scene[x + 1,y] != LocationObject.Terrain)
                {
                   x++;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = one,
                X = x,
                Y = y
            });
        }
         private void Action (int x,int y)
         {
            switch (area.Location[area.Current].Scene[x, y])
            {
                case LocationObject.Exit:
                    area.MoveNext(); break;
                case LocationObject.Entrance:
                    area.MoveBack(); break;
                case LocationObject.Enemy:
                    var enemy = new EnemyFactory();
                    var fight = new Fight(_fightNotifiations);
                   fight.FightHappend(enemy.Enemy[area.Current]);
                    break;
            }
         }
    }
}
