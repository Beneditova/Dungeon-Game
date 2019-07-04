using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dungeon.Core
{
    public class GathererManager : Location
    {
        private int x = 0, y = 0;

        private int maxX = LocationOne.GetLength(0), maxY = LocationOne.GetLength(1);

        private readonly ILocationEventHandler _locationEventHandler;

        public GathererManager(ILocationEventHandler locationEventHandler)
        {
            this._locationEventHandler = locationEventHandler;
        }

        public void MoveRight()
        {
            if (!y.Equals(maxY - 1))
            {
                if (LocationOne[x, y + 1] == LocationObject.Enemy)
                {
                   //Console.WriteLine("The fierce battle begins!");
                    LocationOne[x, y + 1] = LocationObject.Path;
                }
                if (LocationOne[x, y + 1] != LocationObject.Terrain)
                {
                    y++;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                X = x,
                Y = y
            });
        }

        public void MoveLeft()
        {
            if (!y.Equals(0))
            {
                if (LocationOne[x, y - 1] != LocationObject.Terrain)
                {
                    y--;
                }
            }
           
            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                X = x,
                Y = y
            });
        }

        public void MoveUp()
        {
            if (!x.Equals(0))
            {
                if (LocationOne[x - 1, y] != LocationObject.Terrain)
                {
                   x--;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                X = x,
                Y = y
            });
        }

        public void MoveDown()
        {
            if (x + 1 < maxX)
            {
                if (LocationOne[x+1,y] != LocationObject.Terrain)
                {
                   x++;
                }
            }

            this._locationEventHandler.PlayerMoved(this, new GathererPosition
            {
                X = x,
                Y = y
            });
        }
    }
}
