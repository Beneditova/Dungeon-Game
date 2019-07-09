using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Core
{
    public class LocationCollector
    {
        public static List<Location> Location = new List<Location>
        {
            new Location()
            {
               Scene = new LocationObject[,]
               {
                   { LocationObject.Player, LocationObject.Path, LocationObject.Enemy, LocationObject.Path },
                  { LocationObject.Terrain, LocationObject.Terrain, LocationObject.Path, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
               }
            },
            new Location()
            {
               Scene = new LocationObject[,]
               { { LocationObject.Player, LocationObject.Path, LocationObject.Path, LocationObject.Terrain },
                  { LocationObject.Terrain, LocationObject.Enemy, LocationObject.Terrain, LocationObject.Path },
                  { LocationObject.Path, LocationObject.Path, LocationObject.Path, LocationObject.Path},
               }
            }
        };
    }
}

