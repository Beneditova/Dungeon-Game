using System;

namespace Dungeon.Core
{
    public class GathererManager
    {
        private int x = 0, y = 0;
        private int maxX = one.Location[one.Current].Scene.GetLength(0), maxY = one.Location[one.Current].Scene.GetLength(1);

        static LocationCollector one = new LocationCollector();

        private readonly ILocationEventHandler _locationEventHandler;
        private readonly IFightNotifiations _fightNotifications;

        public GathererManager(ILocationEventHandler locationEventHandler, IFightNotifiations fightNotifications)
        {
            this._locationEventHandler = locationEventHandler;
            this._fightNotifications = fightNotifications;
        }

        public void MoveRight()
        {
            if (!y.Equals(maxY - 1))
            {
                switch (one.Location[one.Current].Scene[x, y + 1])
                {
                    case LocationObject.Exit:
                        one.MoveNext(); break;
                    case LocationObject.Entrance:
                        one.MoveBack(); break;
                    case LocationObject.Enemy:
                        var fight = new Fight(_fightNotifications);
                        fight.FightHappend();
                         break;
                }
               
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
                switch (one.Location[one.Current].Scene[x, y - 1])
                {
                    case LocationObject.Exit:
                        one.MoveNext(); break;
                    case LocationObject.Entrance:
                        one.MoveBack(); break;
                    case LocationObject.Enemy:
                        var fight = new Fight(_fightNotifications);
                        fight.FightHappend();
                        break;

                }
               
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
                switch (one.Location[one.Current].Scene[x - 1, y])
                {
                    case LocationObject.Exit:
                        one.MoveNext(); break;
                    case LocationObject.Entrance:
                        one.MoveBack(); break;
                    case LocationObject.Enemy:
                        var fight = new Fight(_fightNotifications);
                        fight.FightHappend();
                        break;
                }

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
                switch (one.Location[one.Current].Scene[x + 1, y])
                {
                    case LocationObject.Exit:
                        one.MoveNext(); break;
                    case LocationObject.Entrance:
                        one.MoveBack(); break;
                    case LocationObject.Enemy:
                        var fight = new Fight(_fightNotifications);
                        fight.FightHappend();
                        break;
                }

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
    }
}
