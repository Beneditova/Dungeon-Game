﻿using System;

namespace Dungeon.Core
{
    public class GathererManager
    {
        public  int x = 0, y = 0;

        public static  LocationCollector Area = new LocationCollector();

        
        private readonly IFightNotifiations _fightNotifiations;
        private readonly ILocationEventHandler _locationEventHandler;

        public GathererManager(IFightNotifiations fightNotifiations,  ILocationEventHandler locationEventHandler)
        {
            this._fightNotifiations = fightNotifiations;
            this._locationEventHandler = locationEventHandler;
        }

        public void MoveRight()
        {
            if (!y.Equals(Area.MaxY - 1))
            {
                    Action(x, y + 1);
                    if (Area.Location[Area.Current].Scene[x, y + 1] != LocationObject.Terrain)
                    {
                        y++;
                    }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = Area,
                X = x,
                Y = y
            });
          
        }

        public void MoveLeft()
        {
            if (!y.Equals(0))
            {
                Action(x, y - 1);

                if (Area.Location[Area.Current].Scene[x, y - 1] != LocationObject.Terrain)
                {
                    y--;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = Area,
                X = x,
                Y = y
            });
        }

        public void MoveUp()
        {
            if (!x.Equals(0))
            {
                Action(x - 1, y);

                if (Area.Location[Area.Current].Scene[x - 1, y] != LocationObject.Terrain)
                {
                   x--;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = Area,
                X = x,
                Y = y
            });
        }

        public void MoveDown()
        {
            if (x + 1 < Area.MaxX)
            {
                Action(x + 1, y);

                if (Area.Location[Area.Current].Scene[x + 1,y] != LocationObject.Terrain)
                {
                   x++;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                Scene = Area,
                X = x,
                Y = y
            });
        }

        private void Action (int x,int y)
        {
            switch (Area.Location[Area.Current].Scene[x, y])
            {
                case LocationObject.Exit:
                    Area.MoveNext(); 
                    break;
                case LocationObject.Entrance:
                    Area.MoveBack(); break;
                case LocationObject.Enemy:
                    var enemy = new EnemyFactory();
                    var fight = new Fight(_fightNotifiations);
                   fight.FightHappend(enemy.Enemy[Area.Current]);
                    break;
            }
        }
    }
}
